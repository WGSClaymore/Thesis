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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Thesis.UpdatedForms
{
    public partial class formDocIn : Form
    {
        SqlConnection Con;
        public formDocIn()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
      
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT DocIn_ID AS 'ID', Document_Title AS 'Document Title', Date, Source, Recieved_By AS 'Recieved By' FROM DocIn_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDocIn.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void clearselect()
        {
            dgvDocIn.ClearSelection();
            foreach (DataGridViewColumn column in dgvDocIn.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DocIn_Tbl VALUES (@Document_Title, @Date, @Source, @Recieved_By)", Con);
                cmd.Parameters.AddWithValue("@Document_Title", txtDocTitle.Text);
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@Source", txtSource.Text);
                cmd.Parameters.AddWithValue("@Recieved_By", txtRecieved.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Document logged", "Success!");
                Con.Close();
                populate();
                cleartext();
                clearselect();
            } 
            catch
            {
                Con.Close();
                MessageBox.Show("An Error Occurred!", "Error!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this document entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    string updateQuery = "UPDATE DocIn_Tbl SET Document_Title=@Title, Date=@Date, Source=@Source, Recieved_By=@Recieved WHERE DocIn_ID=@ID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, Con);
                    updateCommand.Parameters.AddWithValue("@ID", lblDocID.Text);
                    updateCommand.Parameters.AddWithValue("@Title", txtDocTitle.Text);
                    updateCommand.Parameters.AddWithValue("@Date", dtpDate.Text);
                    updateCommand.Parameters.AddWithValue("@Source", txtSource.Text);
                    updateCommand.Parameters.AddWithValue("@Recieved", txtRecieved.Text);                
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

        private void formDocIn_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void txtDocTitle_TextChanged(object sender, EventArgs e)
        {

        }
        private void cleartext()
        {
            txtDocTitle.Clear();
            txtRecieved.Clear();
            txtSource.Clear();
        }
        private void dgvDocIn_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDocIn.Rows.Count)
            {
                DataGridViewRow row = dgvDocIn.Rows[e.RowIndex];

                lblDocID.Text = Convert.ToString(row.Cells["ID"].Value);
                txtDocTitle.Text = Convert.ToString(row.Cells["Document Title"].Value);
                txtSource.Text = Convert.ToString(row.Cells["Source"].Value);
                txtRecieved.Text = Convert.ToString(row.Cells["Recieved By"].Value);
                
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn clickedColumn = dgvDocIn.Columns[e.ColumnIndex];

                // Check if it's the header column (index 0)
                if (e.ColumnIndex > 0)
                {
                    // Set the minimum width for the column
                    int minimumWidth = 300; // Specify your desired minimum width

                    // Set the AutoSizeMode of the column to DisplayedCells
                    switch (clickedColumn.Name)
                    {
                        case "ID":
                            // Disable auto-sizing for ColumnName1 and ColumnName2
                            clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            clickedColumn.Width = minimumWidth; // Set the minimum width
                            break;
                        default:
                            // Enable auto-sizing for other columns
                            clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            break;
                    }

                    if (clickedColumn.AutoSizeMode != DataGridViewAutoSizeColumnMode.None)
                    {
                        // Store the original AutoSizeMode value
                        DataGridViewAutoSizeColumnMode originalAutoSizeMode = clickedColumn.AutoSizeMode;

                        // Disable auto-sizing for the clicked column
                        clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        // If clicked again, restore the original AutoSizeMode
                        if (clickedColumn.Tag == null)
                        {
                            clickedColumn.Tag = originalAutoSizeMode;
                        }
                        else
                        {
                            clickedColumn.AutoSizeMode = (DataGridViewAutoSizeColumnMode)clickedColumn.Tag;
                            clickedColumn.Tag = null;
                        }
                    }
                }
            }
        }

        private void formDocIn_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
}
