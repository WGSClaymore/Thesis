using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Thesis.UpdatedForms
{
    public partial class formComplaintStatus : Form
    {
        SqlConnection Con;
        public formComplaintStatus()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
           
        }
        private void formComplaintStatus_Load(object sender, EventArgs e)
        {
            populate();
            populateReceived();
            ClearSelect();
            lblComplaintIDEntry.Hide();
            lblResolvedComplaint.Hide();
            lblInitComplaint.Hide();
        }
        private void ClearSelect()
        {
            dgvFinal.ClearSelection();
            dgvComplaint.ClearSelection();
            foreach (DataGridViewColumn column in dgvFinal.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in dgvComplaint.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void Cleartext()
        {
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";
            dtpUpdate.Text = "";
            Action.Clear();
            Remarks.Clear();
        }
      
        void populateReceived()
        {
            Con.Open();
            string Myquery = "SELECT RCmplt_ID AS 'ID', Complaintant, Status, Address, Nature_of_Complaint AS 'Nature of Complaint', Telephone_No AS 'Telephone Number', Description, Date_Submitted AS 'Date Submitted' FROM ReceivedComp_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvComplaint.DataSource = ds.Tables[0];
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT Cmplt_ID as ID, Complaintant, Status, Address,  Nature_of_Complaint AS 'Nature of Complaint', Telephone_No AS 'Telephone Number', Description, Date_Submitted AS 'Date Submitted', Date_Updated AS 'Date Updated', Actions_Taken AS 'Actions Taken', Remarks FROM Complaint_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvFinal.DataSource = ds.Tables[0];
            Con.Close();
        }
      
        private void dgvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblInitComplaint.Hide();
            lblComplaintIDEntry.Show();
            dgvComplaint.ClearSelection();
            lblInitComplaint.Hide();
            lblResolvedComplaint.Show();
            foreach (DataGridViewColumn column in dgvComplaint.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (e.RowIndex >= 0 && e.RowIndex < dgvFinal.Rows.Count)
            {
                DataGridViewRow row = dgvFinal.Rows[e.RowIndex];

                lblComplaintIDEntry.Text = Convert.ToString(row.Cells["ID"].Value);
                CompName.Text = Convert.ToString(row.Cells["Complaintant"].Value);
                Status.Text = Convert.ToString(row.Cells["Status"].Value);
                Address.Text = Convert.ToString(row.Cells["Address"].Value);
                Nature.Text = Convert.ToString(row.Cells["Nature of Complaint"].Value);
                TelNo.Text = Convert.ToString(row.Cells["Telephone Number"].Value);
                Desc.Text = Convert.ToString(row.Cells["Description"].Value);
                Date.Text = Convert.ToString(row.Cells["Date Submitted"].Value);
                dtpUpdate.Text = Convert.ToString(row.Cells["Date Updated"].Value);
                Action.Text = Convert.ToString(row.Cells["Actions Taken"].Value);
                Remarks.Text = Convert.ToString(row.Cells["Remarks"].Value);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn clickedColumn = dgvFinal.Columns[e.ColumnIndex];

                switch (clickedColumn.Name)
                {
                    case "ID":
                                                       
                        // Disable auto-sizing for ColumnName1 and ColumnName2
                        clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
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

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
             
                try
                {
                    Con.Open();
                    string insertQuery = "INSERT INTO Complaint_Tbl (Complaintant, Status, Address, Nature_of_Complaint, Telephone_No, Description, Date_Submitted, Date_Updated, Actions_Taken, Remarks) " +
                     "VALUES (@Complaintant, @Status, @Address, @Nature_of_Complaint, @Telephone_No, @Description, @Date_Submitted, @Date_Updated, @Actions_Taken, @Remarks)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, Con);
                    insertCommand.Parameters.AddWithValue("@Complaintant", CompName.Text);
                    insertCommand.Parameters.AddWithValue("@Status", Status.Text);
                    insertCommand.Parameters.AddWithValue("@Address", Address.Text);
                    insertCommand.Parameters.AddWithValue("@Nature_of_Complaint", Nature.Text);
                    insertCommand.Parameters.AddWithValue("@Telephone_No", TelNo.Text);
                    insertCommand.Parameters.AddWithValue("@Description", Desc.Text);
                    insertCommand.Parameters.AddWithValue("@Date_Submitted", Date.Text);
                    insertCommand.Parameters.AddWithValue("@Date_Updated", dtpUpdate.Text);
                    insertCommand.Parameters.AddWithValue("@Actions_Taken", Action.Text);
                    insertCommand.Parameters.AddWithValue("@Remarks", Remarks.Text);
                    insertCommand.ExecuteNonQuery();
                    string Myquery = "DELETE FROM ReceivedComp_Tbl WHERE RCmplt_ID='" + lblInitComplaint.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(Myquery, Con);                   
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Complaint successfully updated", "Success");
                    Con.Close();
                    populate();
                    populateReceived();
                    Cleartext();
                    ClearSelect();
                }
                catch (Exception ex )
                {
                    Console.WriteLine("An error occurred. " + ex.Message);
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
                    {
                     Con.Open();
                        string updateQuery = "UPDATE Complaint_Tbl SET Complaintant=@Complaintant, Status=@Status, Address=@Address, Nature_of_Complaint=@Nature, " +
                        "Telephone_No=@TelNo, Description=@Desc, Date_Submitted=@Date, Date_Updated=@UpdateDate, Actions_Taken=@Action, Remarks=@Remarks " +
                        "WHERE Cmplt_ID=@ComplaintID";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, Con);
                        updateCommand.Parameters.AddWithValue("@Complaintant", CompName.Text);
                        updateCommand.Parameters.AddWithValue("@Status", Status.Text);
                        updateCommand.Parameters.AddWithValue("@Address", Address.Text);
                        updateCommand.Parameters.AddWithValue("@Nature", Nature.Text);
                        updateCommand.Parameters.AddWithValue("@TelNo", TelNo.Text);
                        updateCommand.Parameters.AddWithValue("@Desc", Desc.Text);
                        updateCommand.Parameters.AddWithValue("@Date", Date.Text);
                        updateCommand.Parameters.AddWithValue("@UpdateDate", dtpUpdate.Text);
                        updateCommand.Parameters.AddWithValue("@Action", Action.Text);
                        updateCommand.Parameters.AddWithValue("@Remarks", Remarks.Text);
                        updateCommand.Parameters.AddWithValue("@ComplaintID", lblComplaintIDEntry.Text);
                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("Complaint successfully edited", "Success");                       
                        Con.Close();
                        populate();
                        Cleartext();
                        ClearSelect();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 8152) // Error number for "String or binary data would be truncated"
                    {
                        MessageBox.Show("Error: String or binary data would be truncated.", "Error");
                    }
                    else
                    {
                        MessageBox.Show("SQL Error: " + ex.Message, "Exceeding character count of 50");
                    }
                    Con.Close();
                }
            }
           
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                try
                {
                    if (result == DialogResult.Yes)
                    {
                        Con.Open();
                        string Myquery = "DELETE FROM Complaint_Tbl WHERE Cmplt_ID='" + lblComplaintIDEntry.Text + "'";
                        SqlCommand cmd = new SqlCommand(Myquery, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Complaint Successfully Deleted","Success");
                        Con.Close();
                        populate();
                        Cleartext();
                        ClearSelect();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred. " + ex.Message);
                }
            }
            
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formComplaintStatus_Click(object sender, EventArgs e)
        {
            ClearSelect();          
        }

        private void dgvComplaint_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lblComplaintIDEntry.Hide();
            lblInitComplaint.Show();
            dgvFinal.ClearSelection();
            lblResolvedComplaint.Hide();
            lblInitComplaint.Show();
            lblComplaintIDEntry.Text = "";
            foreach (DataGridViewColumn column in dgvFinal.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (e.RowIndex >= 0 && e.RowIndex < dgvComplaint.Rows.Count)
            {
                DataGridViewRow row = dgvComplaint.Rows[e.RowIndex];

                lblInitComplaint.Text = Convert.ToString(row.Cells["ID"].Value);
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

                switch (clickedColumn.Name)
                {
                    case "ID":


                        // Disable auto-sizing for ColumnName1 and ColumnName2
                        clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
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
}
