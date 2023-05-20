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
      

        private void dgvComplaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblComplaintIDEntry.Hide();
            lblInitComplaint.Show();
            dgvFinal.ClearSelection();
            lblResolvedComplaint.Hide();
            lblInitComplaint.Show();
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

        private void dgvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblInitComplaint.Hide();
            lblComplaintIDEntry.Show();
            dgvComplaint.ClearSelection();
            lblInitComplaint.Hide();
            lblResolvedComplaint.Show();
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
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Complaint_Tbl VALUES('" + CompName.Text + "', '" + Status.Text + "', " +
            "'" + Address.Text + "', '" + Nature.Text + "', '" + TelNo.Text + "', '" + Desc.Text + "', '" + Date.Text + "', '" + dtpUpdate.Text + "', " +
            "'" + Action.Text + "', '" + Remarks.Text + "')", Con);
            string Myquery = "DELETE FROM ReceivedComp_Tbl WHERE RCmplt_ID='" + lblComplaintIDEntry.Text + "'";
            SqlCommand cmd2 = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Complaint successfully updated");
            Con.Close();
            populate();
            populateReceived();
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
            ClearSelect();
        }

        private void btnEditComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Complaint_Tbl SET Complaintant='" + CompName.Text + "', Status= '" + Status.Text + "', " +
            "Address= '" + Address.Text + "', Nature_of_Complaint='" + Nature.Text + "', Telephone_No='" + TelNo.Text + "', Description='" + Desc.Text + "', " +
            "Date_Submitted='" + Date.Text + "', Date_Updated='" + dtpUpdate.Text + "', Actions_Taken='" + Action.Text + "', Remarks='" + Remarks.Text + "' WHERE Cmplt_ID ='"+lblComplaintIDEntry.Text+"' ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint successfully edited");
            Con.Close();
            populate();
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
            ClearSelect();
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from Complaint_Tbl where Cmplt_ID='" + lblComplaintIDEntry.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Successfully Deleted");
            Con.Close();
            populate();
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
            ClearSelect();
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formComplaintStatus_Click(object sender, EventArgs e)
        {
            ClearSelect();
          
        }
    }
}
