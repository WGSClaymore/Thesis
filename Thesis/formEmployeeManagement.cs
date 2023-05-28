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
    public partial class formEmployeeManagement : Form
    {
        SqlConnection Con;

        public formEmployeeManagement()
        {
            InitializeComponent();
           
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
           
        }
       
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT EmpInfo_ID AS 'Employee ID',FirstName AS 'First Name',LastName AS 'Last Name',MiddleName AS  'Middle Name',Suffix, EmpName AS 'Employee Name',DOB AS 'Date of Birth'," +
                "Position, Area_of_Assignment AS 'Area of Assignment', Employee_ID_No AS 'Employee ID Number', " +
                "Address, Gender, National_IDNo AS 'National ID Number', GSIS_No AS 'GSIS Number', PAGIBIG_No AS 'PAGIBIG Number'," +
                "SSS_No AS 'SSS Number', TIN, PHILHEALTH_No AS 'Philhealth Number', ECI_Name AS 'ECI Name', ECI_Contact_No AS 'ECI Contact Number', " +
                "ECI_Address AS 'ECI Address' FROM EmployeeInfo_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvEmployeeInfo.DataSource = ds.Tables[0];
            Con.Close();
            clearselect();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO EmployeeInfo_Tbl(FirstName,LastName,MiddleName,Suffix,EmpName,Position,DOB,Area_of_Assignment,Employee_ID_No,Address," +
            "Gender,National_IDNo,GSIS_No,PAGIBIG_No,SSS_No,TIN,PHILHEALTH_No,ECI_Name,ECI_Contact_No,ECI_Address)VALUES(@fname,@lname,@mname," +
            "@suffix,@empname,@position,@dob,@DaS,@empid,@address,@gender,@natid,@gsis,@pag,@sss,@tin,@phil,@emerconname,@emerconno,@emerconaddress)";
            using (SqlConnection Con = GetConnection())
            {
               
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                string val = string.Concat(txtEmpfname.Text, ' ', txtEmpmname.Text, ' ', txtEmplname.Text, ' ', txtSuffix.Text);
                cmd.Parameters.AddWithValue("@fname", SqlDbType.Text).Value = txtEmpfname.Text;
                cmd.Parameters.AddWithValue("@lname", SqlDbType.Text).Value = txtEmplname.Text;
                cmd.Parameters.AddWithValue("@mname", SqlDbType.Text).Value = txtEmpmname.Text;
                cmd.Parameters.AddWithValue("@suffix", SqlDbType.Text).Value = txtSuffix.Text;
                cmd.Parameters.AddWithValue("@empname", val);
                cmd.Parameters.AddWithValue("@position", SqlDbType.Text).Value = txtPos.Text;
                cmd.Parameters.AddWithValue("@dob", SqlDbType.Text).Value = dtpEmpDOB.Text;
                cmd.Parameters.AddWithValue("@DaS", SqlDbType.Text).Value = txtAoA.Text;
                cmd.Parameters.AddWithValue("@empid", SqlDbType.Text).Value = txtEmpID.Text;
                cmd.Parameters.AddWithValue("@address", SqlDbType.Text).Value = address.Text;
                cmd.Parameters.AddWithValue("@gender", SqlDbType.Text).Value = Gender.Text;
                cmd.Parameters.AddWithValue("@natid", SqlDbType.Text).Value = NatID.Text;
                cmd.Parameters.AddWithValue("@gsis", SqlDbType.Text).Value = GSIS.Text;
                cmd.Parameters.AddWithValue("@pag", SqlDbType.Text).Value = PAGIBIG.Text;
                cmd.Parameters.AddWithValue("@sss", SqlDbType.Text).Value = SSS.Text;
                cmd.Parameters.AddWithValue("@tin", SqlDbType.Text).Value = TIN.Text;
                cmd.Parameters.AddWithValue("@phil", SqlDbType.Text).Value = PHIL.Text;
                cmd.Parameters.AddWithValue("@emerconname", SqlDbType.Text).Value = EmerName.Text;
                cmd.Parameters.AddWithValue("@emerconno", SqlDbType.Text).Value = EmerCon.Text;
                cmd.Parameters.AddWithValue("@emerconaddress", SqlDbType.Text).Value = EmerAddress.Text;
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            cleartext();
            populate();
            clearselect();
        }
        private SqlConnection GetConnection()
        {
          
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return new SqlConnection(connectionString);
        }
        private void formEmployeeManagement_Load(object sender, EventArgs e)
        {
            populate();
           
        }

      

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmployeeInfo.Rows.Count)
            {
                DataGridViewRow row = dgvEmployeeInfo.Rows[e.RowIndex];

                txtEmpfname.Text = Convert.ToString(row.Cells["First Name"].Value);
                txtEmplname.Text = Convert.ToString(row.Cells["Last Name"].Value);
                txtEmpmname.Text = Convert.ToString(row.Cells["Middle Name"].Value);
                txtSuffix.Text = Convert.ToString(row.Cells["Suffix"].Value);
                label3.Text = Convert.ToString(row.Cells["Employee Name"].Value);
                dtpEmpDOB.Text = Convert.ToString(row.Cells["Date of Birth"].Value);
                txtPos.Text = Convert.ToString(row.Cells["Position"].Value);
                txtAoA.Text = Convert.ToString(row.Cells["Area of Assignment"].Value);
                txtEmpID.Text = Convert.ToString(row.Cells["Employee ID Number"].Value);
                address.Text = Convert.ToString(row.Cells["Address"].Value);
                Gender.Text = Convert.ToString(row.Cells["Gender"].Value);
                NatID.Text = Convert.ToString(row.Cells["National ID Number"].Value);
                GSIS.Text = Convert.ToString(row.Cells["GSIS Number"].Value);
                PAGIBIG.Text = Convert.ToString(row.Cells["PAGIBIG Number"].Value);
                SSS.Text = Convert.ToString(row.Cells["SSS Number"].Value);
                PHIL.Text = Convert.ToString(row.Cells["PHILHEALTH Number"].Value);
                EmerName.Text = Convert.ToString(row.Cells["ECI Name"].Value);
                EmerCon.Text = Convert.ToString(row.Cells["ECI Contact Number"].Value);
                EmerAddress.Text = Convert.ToString(row.Cells["ECI Address"].Value);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn clickedColumn = dgvEmployeeInfo.Columns[e.ColumnIndex];

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

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    string Myquery = "delete from EmployeeInfo_Tbl where EmpName='" + label3.Text + "'";
                    SqlCommand cmd = new SqlCommand(Myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information successfully deleted", "Success!");
                    Con.Close();
                    populate();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
            }
                    
        }
        private void cleartext()
        {
            txtEmplname.Clear();
            txtEmpfname.Clear();
            txtEmpmname.Clear();
            txtSuffix.Clear();
            txtPos.Clear();
            txtAoA.Clear();
            txtEmpID.Clear();
            address.Clear();
            Gender.Text = "";
            NatID.Clear();
            GSIS.Clear();
            PAGIBIG.Clear();
            SSS.Clear();
            TIN.Clear();
            PHIL.Clear();
            EmerName.Clear();
            EmerCon.Clear();
            EmerAddress.Clear();
        }
        private void clearselect()
        {
            dgvEmployeeInfo.ClearSelection();
            foreach (DataGridViewColumn column in dgvEmployeeInfo.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void formEmployeeManagement_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
}
