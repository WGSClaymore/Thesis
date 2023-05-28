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
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

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
            string Myquery = "SELECT FirstName AS 'First Name',LastName AS 'Last Name',MiddleName AS 'Middle Name',Suffix,Employee_ID_No FROM EmployeeInfo_Tbl";
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
            string Myquery = "SELECT Task_Name AS 'Task Name' ,Responsible_Person AS 'Person Responsible' FROM TaskManagement_Tbl";
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
            string Myquery = "SELECT TaskAssign_ID AS 'Task ID', Task_Name AS 'Task Name', Responsible_Person AS 'Person Responsible', EmpName AS 'Employee Name' FROM TaskAssign_Tbl";
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
            SqlCommand cmd = new SqlCommand("INSERT INTO TaskAssign_Tbl values ('" + txtTaskName.Text + "','" + txtRespPerson.Text + "','" + txtEmpName.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task assignment successfully added", "Success!");
            Con.Close();
            populate();
            cleartext();
            clearselect();
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
            SqlCommand cmd = new SqlCommand("UPDATE TaskAssign_Tbl SET Task_Name='" + txtTaskName.Text + "', Responsible_Person='" + txtRespPerson.Text + "'" +
            "EmpName='" + txtEmpName.Text + "' WHERE TaskAssign_ID = '"+lblTaskAssignID.Text+"'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task assignment successfully edited", "Success!");
            Con.Close();
            populate();
            cleartext();
            clearselect();
        }

        private void dgvTaskAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTask.ClearSelection();
            dgvEmployeeInfo.ClearSelection();
            if (e.RowIndex >= 0 && e.RowIndex < dgvTaskAssign.Rows.Count)
            {
                DataGridViewRow row = dgvTaskAssign.Rows[e.RowIndex];
                lblTaskAssignID.Text = Convert.ToString(row.Cells["Task ID"].Value);

                txtTaskName.Text = Convert.ToString(row.Cells["Task Name"].Value);
                txtRespPerson.Text = Convert.ToString(row.Cells["Person Responsible"].Value);
                txtEmpName.Text = Convert.ToString(row.Cells["Employee Name"].Value);
            }

        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.RowIndex < dgvTaskAssign.Rows.Count)
            {
                DataGridViewRow row = dgvTaskAssign.Rows[e.RowIndex];
                txtTaskName.Text = Convert.ToString(row.Cells["Task Name"].Value);
                txtRespPerson.Text = Convert.ToString(row.Cells["Person Responsible"].Value);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmployeeInfo.Rows.Count)
            {
                //    DataGridViewRow row = dgvEmployeeInfo.Rows[e.RowIndex];
                //  txtEmpName.Text = Convert.ToString(row.Cells["Employee Name"].Value);
            }
        }
        private void cleartext()
        {
            txtTaskName.Clear();
            txtRespPerson.Clear();
            txtEmpName.Clear();
        }
        private void clearselect()
        {
            dgvTask.ClearSelection();
            dgvTaskAssign.ClearSelection();
            dgvEmployeeInfo.ClearSelection();
            foreach (DataGridViewColumn column in dgvTask.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in dgvEmployeeInfo.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in dgvTaskAssign.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void formTaskAssignment_Click(object sender, EventArgs e)
        {
            dgvTask.ClearSelection();
            dgvTaskAssign.ClearSelection();
            dgvEmployeeInfo.ClearSelection();
        }
    }
}
