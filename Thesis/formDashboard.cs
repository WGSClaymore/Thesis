using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thesis.UpdatedForms;

namespace Thesis
{
    public partial class Dashboard : Form
    {
        private Form activeForm = null;
        
        public Dashboard()

        {
            InitializeComponent();
            customPanelDesign();
            openChildForm(new formHome());

        }
        private void customPanelDesign()
        {
            subpanelOCRMenu.Visible  = false;
            subpanelProjManagement.Visible = false;
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
        private void btnFileManagement_Click(object sender, EventArgs e)
        {
            if (subpanelOCRMenu.Visible == false)
            {
                subpanelOCRMenu.Visible = true;
            }
            else if (subpanelOCRMenu.Visible == true)
            {
                subpanelOCRMenu.Visible = false;
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new formFileUpload());
           
        }

        private void btnProjectManagement_Click(object sender, EventArgs e)
        {
            if (subpanelProjManagement.Visible == false)
            {
                subpanelProjManagement.Visible = true;
            }
            else if (subpanelProjManagement.Visible == true)
            {
                subpanelProjManagement.Visible = false;
            }
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new formHome());
           
        }

        private void btnPermits_Click(object sender, EventArgs e)
        {
            openChildForm(new formPermitsManagement());
        }

        private void btnFileDatabase_Click(object sender, EventArgs e)
        {
            openChildForm(new formFileDatabase());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subpanelOCRMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new formUserManagement());
        }

        private void btnCommunityComplaints_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            openChildForm(new formEmployeeManagement());
        }

        private void subpanelProjManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
