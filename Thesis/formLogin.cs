using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
  
    public partial class formLogin : Form
    {
        private readonly CENRO_DB_FinalEntities _DB_FinalEntities;
        public formLogin()
        {
            InitializeComponent();
            _DB_FinalEntities = new CENRO_DB_FinalEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text;

                var user = _DB_FinalEntities.Users.FirstOrDefault(q => q.Username == username && q.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                */
                {
                    var dashboard = new Dashboard(this);
                    dashboard.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occured, please try again");
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
