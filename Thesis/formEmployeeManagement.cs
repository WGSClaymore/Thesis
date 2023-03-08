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

namespace Thesis.UpdatedForms
{
    public partial class formEmployeeManagement : Form
    {
        public formEmployeeManagement()
        {
            InitializeComponent();
        }
       // SqlConnection Con = new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select EmpInfo_ID,FirstName,LastName,MiddleName,Suffix,DOB from EmployeeInfo_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvEmployeeInfo.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO EmployeeInfo_Tbl(FirstName,LastName,MiddleName,Suffix,EmpName,DOB,Position,Area_of_Assignment,Employee_ID_No)VALUES(@fname,@lname,@mname,@suffix,@empname,@dob,@position,@AOA,@empid)";
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                string val = string.Concat(txtEmpfname.Text, ' ', txtEmpmname.Text, ' ', txtEmplname.Text, ' ', txtSuffix.Text);
                cmd.Parameters.AddWithValue("@fname", SqlDbType.Text).Value = txtEmpfname.Text;
                cmd.Parameters.AddWithValue("@lname", SqlDbType.Text).Value = txtEmplname.Text;
                cmd.Parameters.AddWithValue("@mname", SqlDbType.Text).Value = txtEmpmname.Text;
                cmd.Parameters.AddWithValue("@suffix", SqlDbType.Text).Value = txtSuffix.Text;
                cmd.Parameters.AddWithValue("@empname", val);
                cmd.Parameters.AddWithValue("@dob", SqlDbType.Text).Value = dtpEmpDOB.Text;
                cmd.Parameters.AddWithValue("@position", SqlDbType.Text).Value = txtPos.Text;
                cmd.Parameters.AddWithValue("@AOA", SqlDbType.Text).Value = txtAoA.Text;
                cmd.Parameters.AddWithValue("@empid", SqlDbType.Text).Value = txtEmpID.Text;
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            txtEmplname.Clear();
            txtEmpfname.Clear();
            txtEmpmname.Clear();
            txtSuffix.Clear();
            txtPos.Clear();
            txtAoA.Clear();
            txtEmpID.Clear();
            populate();
        }
        private SqlConnection GetConnection()
        {
            //return new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        }
        private void formEmployeeManagement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update EmployeeInfo_Tbl set FirstName='" + txtEmpfname.Text + "', LastName= '" + txtEmplname.Text + "', " +
            "MiddleName= '" + txtEmpmname.Text + "', Suffix='" + txtSuffix.Text + "', DOB='" + dtpEmpDOB.Text + "', PlntPos='" + txtPos.Text + "', " +
            "Area_of_Assignment='" + txtAoA.Text + "', Employee_ID_No='" + txtEmpID.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Information Successfully Updated");
            Con.Close();
            populate();
            txtEmplname.Clear();
            txtEmpfname.Clear();
            txtEmpmname.Clear();
            txtSuffix.Text = "";
            dtpEmpDOB.Text = "";
            txtPos.Clear();
            txtAoA.Clear();
            txtEmpID.Clear();
        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dgvEmployeeInfo.SelectedRows[0].Cells[1].Value.ToString();
            dtpEmpDOB.Text = dgvEmployeeInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtPos.Text = dgvEmployeeInfo.SelectedRows[0].Cells[3].Value.ToString();
            txtAoA.Text = dgvEmployeeInfo.SelectedRows[0].Cells[4].Value.ToString();
            txtEmpID.Text = dgvEmployeeInfo.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from EmployeeInfo_Tbl where FirstName='" + txtEmpfname.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Successfully Deleted");
            Con.Close();
            populate();
            txtEmplname.Clear();
            txtEmpfname.Clear();
            txtEmpmname.Clear();
            txtSuffix.Text = "";
            dtpEmpDOB.Text = "";
            txtPos.Clear();
            txtAoA.Clear();
            txtEmpID.Clear();
        }
    }
}
