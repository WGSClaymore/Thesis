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
        private Button currentButton;
        public Dashboard()

        {
            InitializeComponent();
            customPanelDesign();
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

        }

        private void btnFileDatabase_Click(object sender, EventArgs e)
        {
            openChildForm(new formFileDatabase());
        }
    }
}
