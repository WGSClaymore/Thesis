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
    public partial class formTaskAssignment : Form
    {
        SqlConnection Con;
        public formTaskAssignment()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
      
        void populateEmp()
        {
            Con.Open();
            string Myquery = "select FirstName,LastName,MiddleName,Suffix,Employee_ID_No from EmployeeInfo_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvEmployeeInfo.DataSource = ds.Tables[0];
            Con.Close();
        }

        void populateTask()
        {
            Con.Open();
            string Myquery = "select Task_Name,Responsible_Person from TaskManagement_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvTask.DataSource = ds.Tables[0];
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string Myquery = "select * from TaskAssign_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvTaskAssign.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into TaskAssign_Tbl values ('" + txtTaskName.Text + "','" + txtRespPerson.Text + "','" + txtEmpName.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task assignment successfully added");
            Con.Close();
            populate();
            txtTaskName.Clear();
            txtRespPerson.Clear();
            txtEmpName.Clear();
        }

        private void formTaskAssignment_Load(object sender, EventArgs e)
        {
            populate();
            populateEmp();
            populateTask();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update TaskAssign_Tbl set Task_Name='" + txtTaskName.Text + "', Responsible_Person='" + txtRespPerson.Text + "', " +
            "EmpName='" + txtEmpName.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task assignment successfully edited");
            Con.Close();
            populate();
            txtTaskName.Clear();
            txtRespPerson.Clear();
            txtEmpName.Clear();
        }

        private void dgvTaskAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaskName.Text = dgvTaskAssign.SelectedRows[0].Cells[1].Value.ToString();
            txtRespPerson.Text = dgvTaskAssign.SelectedRows[0].Cells[2].Value.ToString();
            txtEmpName.Text = dgvTaskAssign.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaskName.Text = dgvTask.SelectedRows[0].Cells[1].Value.ToString();
            txtRespPerson.Text = dgvTask.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
