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
        SqlConnection Con = new SqlConnection(@"Data Source = LAPTOP - OM3OLFRT\SQLEXPRESS01;Initial Catalog = CENRO_DB - Permit - Emp - and - complaints; Integrated Security = True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from EmployeeInfo_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvEmployeeInfo.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into EmployeeInfo_Tbl values('" + txtEmplname.Text + "', '" + txtEmpfname.Text + "', '" + txtEmpmname.Text + "', " +
            "'" + cmbSuffix.Text + "', '" + dtpEmpDOB.Text + "', '" + txtPos.Text + "', '" + txtAoA.Text + "', '" + txtEmpID.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Information Successfully Added");
            Con.Close();
            populate();
            txtEmplname.Clear();
            txtEmpfname.Clear();
            txtEmpmname.Clear();
            cmbSuffix.Text = "";
            dtpEmpDOB.Text = "";
            txtPos.Clear();
            txtAoA.Clear();
            txtEmpID.Clear();
        }

        private void formEmployeeManagement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update EmployeeInfo_Tbl set FirstName='" + txtEmpfname.Text + "', LastName= '" + txtEmplname.Text + "', " +
            "MiddleName= '" + txtEmpmname.Text + "', Suffix='" + cmbSuffix.Text + "', DOB='" + dtpEmpDOB.Text + "', PlntPos='" + txtPos.Text + "', " +
            "Area_of_Assignment='" + txtAoA.Text + "', Employee_ID_No='" + txtEmpID.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Information Successfully Updated");
            Con.Close();
            populate();
            txtEmplname.Clear();
            txtEmpfname.Clear();
            txtEmpmname.Clear();
            cmbSuffix.Text = "";
            dtpEmpDOB.Text = "";
            txtPos.Clear();
            txtAoA.Clear();
            txtEmpID.Clear();
        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmplname.Text = dgvEmployeeInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpfname.Text = dgvEmployeeInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtEmpmname.Text = dgvEmployeeInfo.SelectedRows[0].Cells[3].Value.ToString();
            cmbSuffix.Text = dgvEmployeeInfo.SelectedRows[0].Cells[4].Value.ToString();
            dtpEmpDOB.Text = dgvEmployeeInfo.SelectedRows[0].Cells[5].Value.ToString();
            txtPos.Text = dgvEmployeeInfo.SelectedRows[0].Cells[6].Value.ToString();
            txtAoA.Text = dgvEmployeeInfo.SelectedRows[0].Cells[7].Value.ToString();
            txtEmpID.Text = dgvEmployeeInfo.SelectedRows[0].Cells[8].Value.ToString();
        }
    }
}
