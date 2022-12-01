using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Thesis.UpdatedForms
{
    public partial class formFileDatabase : Form
    {
        public formFileDatabase()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-OM3OLFRT\SQLEXPRESS01;Initial Catalog=CENRO_DB_Final;Integrated Security=True");

        void populate()
        {
            Con.Open();
            string Myquery = "select File_ID,FileType,FileNo,Title,Date,Extension,FileName from Archive_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDocuments.DataSource = ds.Tables[0];
            Con.Close();
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-OM3OLFRT\SQLEXPRESS01;Initial Catalog=CENRO_DB_Final;Integrated Security=True");
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "select File_ID,FileType,FileNo,Title,Date,Extension,FileName from Archive_Tbl";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvDocuments.DataSource = dt;
                }
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDocuments.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }
        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM Archive_Tbl WHERE File_ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }
        private void formFileDatabase_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
