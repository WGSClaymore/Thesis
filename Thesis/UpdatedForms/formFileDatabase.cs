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
            LoadData();
        }
        

        private SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return new SqlConnection(connectionString);
           
        }
        private void LoadData()
        {
            using (SqlConnection Con = GetConnection())
            {
                string query = "SELECT File_ID AS 'File ID',Title,FileName AS 'File Name', FileType AS 'File Type',FileNo AS 'File Number',Date,Extension FROM Archive_Tbl";
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
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void search()
        {
            string searchTerm = txtSearchName.Text;
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadData();
            }
            else
            {
                string SearchConnect = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(SearchConnect))
                {
                    connection.Open();
                    string sql = "SELECT File_ID AS 'File ID', Title,FileName AS 'File Name', FileType AS 'File Type',FileNo AS 'File Number',Date,Extension FROM Archive_Tbl WHERE Title LIKE '%' + @searchTerm + '%'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@searchTerm", searchTerm);
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);
                        BindingSource bindingsource = new BindingSource();
                        bindingsource.DataSource = table;
                        dgvDocuments.DataSource = bindingsource;
                        reader.Close();

                    }
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFileLocation_Enter(object sender, EventArgs e)
        {
            
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();

        }
    }
}
