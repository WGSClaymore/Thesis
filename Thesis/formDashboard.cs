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
        private formLogin _login;
        

        public Dashboard(formLogin login)
        {
            InitializeComponent();
            _login = login;
            customPanelDesign();
            openChildForm(new formHome());
            
        }
        
        

        private void customPanelDesign()
        {
            subpanelOCRMenu.Visible  = false;
            subpanelProjManagement.Visible = false;
            subPanelEmployeeInfo.Visible = false;
            subpanelComplaintsMenu.Visible = false;
            subPanelPermits.Visible = false;
            subpanelDocumentLogging.Visible = false;
            
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

        
    



        private void subpanelProjManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new formTaskInformation());
        }

      

        private void btnEmployeeManagement_Click_1(object sender, EventArgs e)
        {
            if (subPanelEmployeeInfo.Visible == false)
            {
                subPanelEmployeeInfo.Visible = true;
            }
            else if (subPanelEmployeeInfo.Visible == true)
            {
                subPanelEmployeeInfo.Visible = false;
            }
        }

        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new formEmployeeManagement());
        }

        private void btnEmployeePositions_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            openChildForm(new formUserManagement());
        }

        private void btnPermits_Click_2(object sender, EventArgs e)

        {
            if (subPanelPermits.Visible == false)
            {
                subPanelPermits.Visible = true;
            }
            else if (subPanelPermits.Visible == true)
            {
                subPanelPermits.Visible = false;
            }
        }

        private void btnCommunityComplaints_Click_1(object sender, EventArgs e)
        {
            if (subpanelComplaintsMenu.Visible == false)
            {
                subpanelComplaintsMenu.Visible = true;
            }
            else if (subpanelComplaintsMenu.Visible == true)
            {
                subpanelComplaintsMenu.Visible = false;
            }
        }
        private void btnDocumentLogging_Click(object sender, EventArgs e)
        {
            if (subpanelDocumentLogging.Visible == false)
            {
                subpanelDocumentLogging.Visible = true;
            }
            else if (subpanelDocumentLogging.Visible == true)
            {
                subpanelDocumentLogging.Visible = false;
            }
        }

        private void btnFileComplaints_Click(object sender, EventArgs e)
        {
            openChildForm(new formComplaints());
        }

        private void btnComplaintStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new formComplaintStatus());
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void btnOngoingTasks_Click(object sender, EventArgs e)
        {
            openChildForm(new formTaskAssignment());
        }

        private void btnBurial_Click(object sender, EventArgs e)
        {
            openChildForm(new formBurialPermit());
        }
        private void btnExhumationTransfer_Click(object sender, EventArgs e)
        {
            openChildForm(new formExhumationTransfer());
        }

        private void btnExhumationMonitoring_Click(object sender, EventArgs e)
        {
            openChildForm(new formExhumationMonitoring());
        }

        private void btnPlaza_Click(object sender, EventArgs e)
        {
            openChildForm(new formPlazaPermits());
        }

 

        private void btnDocumentBorrowed_Click(object sender, EventArgs e)
        {
            openChildForm(new formDocIn());
        }

        private void btnDocumentReturned_Click(object sender, EventArgs e)
        {
            openChildForm(new formDocOut());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new formUserManagement());

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var login = new formLogin();
            login.Show();
            this.Hide();
        }
    }
}
