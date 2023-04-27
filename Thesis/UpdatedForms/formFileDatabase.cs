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
using System.Configuration;

namespace Thesis.UpdatedForms
{
    public partial class formFileDatabase : Form
    {
        SqlConnection Con;
        public formFileDatabase()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
        

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
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return new SqlConnection(connectionString);
            //return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        }
        private void LoadData()
        {
            using (SqlConnection Con = GetConnection())
            {
                string query = "select File_ID,FileType,FileNo,Title,Date,Extension,FileName from Archive_Tbl";
                SqlDataAdapter adp = new SqlDataAdapter(query, Con);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
