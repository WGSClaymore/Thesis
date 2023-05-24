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
using System.Configuration;

namespace Thesis.UpdatedForms
{
    public partial class formDocOut : Form
    {
        SqlConnection Con;
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public formDocOut()
        {
            InitializeComponent();           
            Con = new SqlConnection(connectionString);
        }
        
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT DocOut_ID AS 'ID', Document_Title AS 'Document Title', Date, Released_By AS 'Released By', Released_To AS 'Released To' FROM DocOut_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDocOut.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void clearselect()
        {
            dgvDocOut.ClearSelection();
            foreach (DataGridViewColumn column in dgvDocOut.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void cleartext()
        {
            txtDocTitle.Clear();
            txtRelBy.Clear();
            txtRelTo.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "INSERT INTO DocOut_Tbl VALUES (@Document_Title, @Date, @Released_By, @Released_To)";
                    using (SqlCommand cmd = new SqlCommand(query, Con)) 
                    {
                        cmd.Parameters.AddWithValue("@Document_Title", txtDocTitle.Text);
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Text);
                        cmd.Parameters.AddWithValue("@Released_By", txtRelBy.Text);
                        cmd.Parameters.AddWithValue("@Released_To", txtRelTo.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Document tracking recorded");
                        }
                        else
                        {
                            MessageBox.Show("Failed to record document tracking", "Error");
                        }
                       
                    }
                    Con.Close();
                }
                populate();
                txtDocTitle.Clear();
                txtRelBy.Clear();
                txtRelTo.Clear();
                clearselect();
            }
            catch
            {

            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    string updateQuery = "UPDATE DocIn_Tbl SET Document_Title=@Title, Date=@Date, Released_By=@ReleasedBy, Released_To=@ReleasedTo WHERE DocIn_ID=@ID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, Con);
                    updateCommand.Parameters.AddWithValue("@ID", lblDocID.Text);
                    updateCommand.Parameters.AddWithValue("@Title", txtDocTitle.Text);
                    updateCommand.Parameters.AddWithValue("@Date", dtpDate.Text);
                    updateCommand.Parameters.AddWithValue("@Released_By", txtRelBy.Text);
                    updateCommand.Parameters.AddWithValue("@Released_To", txtRelTo.Text);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Document log updated.", "Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }

            }
                
        }

        private void formDocOut_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgvDocOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDocOut.Rows.Count)
            {
                DataGridViewRow row = dgvDocOut.Rows[e.RowIndex];

                lblDocID.Text = Convert.ToString(row.Cells["ID"].Value);
                txtDocTitle.Text = Convert.ToString(row.Cells["Document Title"].Value);
                txtRelBy.Text = Convert.ToString(row.Cells["Released By"].Value);
                txtRelTo.Text = Convert.ToString(row.Cells["Released To"].Value);

            }
        }

        private void formDocOut_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
}
