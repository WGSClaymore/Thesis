using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using Thesis.Properties;

namespace Thesis.UpdatedForms
{
    public partial class formUserManagement : Form
    {
        SqlConnection Con;
        public formUserManagement()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }

        private void formUserManagement_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT id AS 'User ID', Username, FirstName AS 'First Name', LastName AS 'Last Name' FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvUsers.DataSource = ds.Tables[0];
            Con.Close();
        }
        void cleartext()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO USERS VALUES('" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User successfully added", "Success!");
            Con.Close();
            populate();
            cleartext();
            clearselect();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "DELETE FROM Users WHERE id='" + lblUserIDNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Profile successfully deleted", "Success!");
            Con.Close();
            populate();
            cleartext();
            clearselect();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUsers.Rows.Count)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                lblUserIDNumber.Text = Convert.ToString(row.Cells["User ID"].Value);
                txtFirstName.Text = Convert.ToString(row.Cells["First Name"].Value);
                txtLastName.Text = Convert.ToString(row.Cells["Last Name"].Value);
                txtUserName.Text = Convert.ToString(row.Cells["Username"].Value);


            }
        }
        private void clearselect()
        {
            dgvUsers.ClearSelection();
         
        }

        private void formUserManagement_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
}
