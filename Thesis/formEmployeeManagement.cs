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
            string Myquery = "SELECT EmpInfo_ID AS 'Employee ID',FirstName AS 'First Name',LastName AS 'Last Name',MiddleName AS  'Middle Initial',Suffix,DOB AS 'Date of Birth' from EmployeeInfo_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvEmployeeInfo.DataSource = ds.Tables[0];
            Con.Close();
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
                txtEmpmname.Text = Convert.ToString(row.Cells["Middle Initial"].Value);
                txtSuffix.Text = Convert.ToString(row.Cells["Suffix"].Value);
                label3.Text = Convert.ToString(row.Cells["EmpName"].Value);
                dtpEmpDOB.Text = Convert.ToString(row.Cells["DOB"].Value);
                txtPos.Text = Convert.ToString(row.Cells["Position"].Value);
                txtAoA.Text = Convert.ToString(row.Cells["Area_of_Assignment"].Value);
                txtEmpID.Text = Convert.ToString(row.Cells["Employee_ID_No"].Value);
                address.Text = Convert.ToString(row.Cells["Address"].Value);
                Gender.Text = Convert.ToString(row.Cells["Gender"].Value);
                NatID.Text = Convert.ToString(row.Cells["National_IDNo"].Value);
                GSIS.Text = Convert.ToString(row.Cells["GSIS_No"].Value);
                PAGIBIG.Text = Convert.ToString(row.Cells["PAGIBIG_No"].Value);
                SSS.Text = Convert.ToString(row.Cells["SSS_No"].Value);
                PHIL.Text = Convert.ToString(row.Cells["PHILHEALTH_No"].Value);
                EmerName.Text = Convert.ToString(row.Cells["ECI_Name"].Value);
                EmerCon.Text = Convert.ToString(row.Cells["ECI_Contact_No"].Value);
                EmerAddress.Text = Convert.ToString(row.Cells["ECI_Address"].Value);
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
            Con.Open();
            string Myquery = "delete from EmployeeInfo_Tbl where FirstName='" + txtEmpfname.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee information successfully deleted");
            Con.Close();
            populate();      
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
        private void dgvEmployeeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
