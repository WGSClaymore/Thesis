using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis.UpdatedForms
{
    
    public partial class formHome : Form
       
    {
        private Form activeForm = null;
        public formHome()
        {
            InitializeComponent();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new formComplaints());
        }

        private void btnViewArchive_Click(object sender, EventArgs e)
        {
            openChildForm(new formFileDatabase());
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            openChildForm(new formTaskInformation());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new formEmployeeManagement());
        }

       
    }
}
