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

namespace Thesis
{
  
    public partial class formLogin : Form
    {
        SqlConnection Con;
        private readonly CENRO_DB_FinalEntities _DB_FinalEntities;
        public formLogin()
        {
            InitializeComponent();
            _DB_FinalEntities = new CENRO_DB_FinalEntities();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
        private void login()
        {
            string loginConnection = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection Con = new SqlConnection(loginConnection))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password", Con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    var dashboard = new Dashboard(this);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                   MessageBox.Show("Invalid username or password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            login();
        }
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void formLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }

        }
    }
}
