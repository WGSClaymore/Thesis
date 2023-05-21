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
    public partial class formComplaints : Form
    {
        SqlConnection Con;
        public formComplaints()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
       
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT RCmplt_ID AS 'Complaint ID' ,Complaintant AS 'Complaintant', " +
                "Status, Address, Nature_Of_Complaint AS 'Nature of Complaint', Telephone_No AS 'Telephone Number'," +
                " Description, Date_Submitted AS 'Date Submitted' FROM ReceivedComp_Tbl";    
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvComplaint.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void cleartext()
        {
            lblComplaintIDEntry.Text = "";
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";

        }
        private void clearselect()
        {            
            dgvComplaint.ClearSelection();            
            foreach (DataGridViewColumn column in dgvComplaint.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void formComplaints_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void btnAddComplaint_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ReceivedComp_Tbl VALUES (@Complaintant, @Status, @Address, @Nature_of_Complaint, @Telephone_No, @Description, @Date_Submitted)", Con);
                cmd.Parameters.AddWithValue("@Complaintant", CompName.Text);
                cmd.Parameters.AddWithValue("@Status", Status.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Nature_of_Complaint", Nature.Text);
                cmd.Parameters.AddWithValue("@Telephone_No", TelNo.Text);
                cmd.Parameters.AddWithValue("@Description", Desc.Text);
                cmd.Parameters.AddWithValue("@Date_Submitted", Date.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint information successfully added", "Success!");
                Con.Close();
                populate();
                cleartext();
                clearselect();

            }
            catch (SqlException ex)
            {

                {
                    if (ex.Number == 8152) // Error number for "String or binary data would be truncated"
                    {
                        MessageBox.Show("Exceeding character count of 50", "Error");
                    }

                    Con.Close();
                }
            }
            
        }

        private void btnEditComplaint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                { 
                    Con.Open();
                    string updateQuery = "UPDATE ReceivedComp_Tbl SET Complaintant=@CompName, Status=@Status, " +
                        "Address=@Address, Nature_of_Complaint=@Nature, Telephone_No=@TelNo, Description=@Desc, " +
                        "Date_Submitted=@Date WHERE RCmplt_ID=@ComplaintID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, Con);
                    updateCommand.Parameters.AddWithValue("@CompName", CompName.Text);
                    updateCommand.Parameters.AddWithValue("@Status", Status.Text);
                    updateCommand.Parameters.AddWithValue("@Address", Address.Text);
                    updateCommand.Parameters.AddWithValue("@Nature", Nature.Text);
                    updateCommand.Parameters.AddWithValue("@TelNo", TelNo.Text);
                    updateCommand.Parameters.AddWithValue("@Desc", Desc.Text);
                    updateCommand.Parameters.AddWithValue("@Date", Date.Text);
                    updateCommand.Parameters.AddWithValue("@ComplaintID", lblComplaintIDEntry.Text);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Complaint information successfully edited","Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch (SqlException ex)
                {

                    {
                       if (ex.Number == 8152) // Error number for "String or binary data would be truncated"
                        {
                            MessageBox.Show("Exceeding character count of 50", "Error");
                        }

                        Con.Close();
                    }
                }
            }
           
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Con.Open();
                string Myquery = "DELETE FROM ReceivedComp_Tbl WHERE RCmplt_ID='" + lblComplaintIDEntry.Text + "'";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint information successfully deleted", "Success!");
                Con.Close();
                populate();
                cleartext();
                clearselect();
            }
               
        }

        private void dgvComplaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dgvComplaint.Rows.Count)
            {
                DataGridViewRow row = dgvComplaint.Rows[e.RowIndex];

                lblComplaintIDEntry.Text = Convert.ToString(row.Cells["Complaint ID"].Value);
                CompName.Text = Convert.ToString(row.Cells["Complaintant"].Value);
                Status.Text = Convert.ToString(row.Cells["Status"].Value);
                Address.Text = Convert.ToString(row.Cells["Address"].Value);
                Nature.Text = Convert.ToString(row.Cells["Nature of Complaint"].Value);
                TelNo.Text = Convert.ToString(row.Cells["Telephone Number"].Value);
                Desc.Text = Convert.ToString(row.Cells["Description"].Value);
                Date.Text = Convert.ToString(row.Cells["Date Submitted"].Value);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn clickedColumn = dgvComplaint.Columns[e.ColumnIndex];

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

        private void dgvComplaint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formComplaints_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
}
