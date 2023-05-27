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
using System.Windows;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;

namespace Thesis.UpdatedForms
{
    public partial class formPlazaPermits : Form
    {
        SqlConnection Con;
       
        public formPlazaPermits()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
      

        //     SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT Permit_ID AS 'Permit ID',  Applicant_Name AS 'Applicant Name', Address, Permit_Type AS 'Permit Type', Location_Name AS 'Location Name', Activity," +
                " Date, Time, Con_Name AS 'Contact Person', Con_Pos AS 'Contact Position', Con_Contact AS 'Contact Person Position', Inspect_Name AS 'Inspector Name'," +
                " Inspect_Contact AS 'Inspector Contact Information' FROM Permit_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvPermit.DataSource = ds.Tables[0];
            Con.Close();
        }
        void cleartext()
        {
            lblPermitIDEntry.Text = "";
            txtApplicantName.Clear();
            txtAddress.Clear();
            txtPermitType.Clear();
            txtLocationName.Clear();
            txtActivity.Clear();
            dtpDateApproved.Text = "";
            txtTime.Clear();
            txtName.Clear();
            txtPosition.Clear();
            txtContact.Clear();
            txtInspectName.Clear();
            txtInspectContact.Clear();
        }
        private void btnAddPermit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Permit_Tbl VALUES('" + txtApplicantName.Text + "', '" + txtAddress.Text + "', " +
            "'" + txtPermitType.Text + "', '" + txtLocationName.Text + "', '" + txtActivity.Text + "', '" + dtpDateApproved.Text + "', '" + txtTime.Text + "', " +
            "'" + txtName.Text + "', '" + txtPosition.Text + "', '" + txtContact.Text + "', '" + txtInspectName.Text + "', '" + txtInspectContact.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Plaza permit successfully added");
            Con.Close();
            populate();
            cleartext();
            clearselect();
        }

        private void formPermitsManagement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnEditPermit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Permit_Tbl SET Applicant_Name='" + txtApplicantName.Text + "', Address= '" + txtAddress.Text + "', " +
                    "Permit_Type= '" + txtPermitType.Text + "', Location_Name='" + txtLocationName.Text + "', Activity='" + txtActivity.Text + "', Date='" + dtpDateApproved.Text + "', " +
                    "Time='" + txtTime.Text + "', Con_Name='" + txtName.Text + "', Con_Pos='" + txtPosition.Text + "', Con_Contact='" + txtContact.Text + "', " +
                    "Inspect_Name='" + txtInspectName.Text + "', Inspect_Contact='" + txtInspectContact.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Plaza permit successfully edited", "Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
            }
              
        }

        private void btnDeletePermit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    string Myquery = "DELETE FROM Permit_Tbl WHERE Permit_ID='" + lblPermitIDEntry.Text + "'";
                    SqlCommand cmd = new SqlCommand(Myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Plaza permit successfully deleted","Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
            }
                   
        }

        private void dgvPermit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPermit.Rows.Count)
            {
                DataGridViewRow row = dgvPermit.Rows[e.RowIndex];
                lblPermitIDEntry.Text = Convert.ToString(row.Cells["Permit ID"].Value);
                txtApplicantName.Text = Convert.ToString(row.Cells["Applicant Name"].Value);
                txtAddress.Text = Convert.ToString(row.Cells["Address"].Value);
                txtPermitType.Text = Convert.ToString(row.Cells["Permit Type"].Value);
                txtLocationName.Text = Convert.ToString(row.Cells["Location Name"].Value);
                txtActivity.Text = Convert.ToString(row.Cells["Activity"].Value);
                dtpDateApproved.Text = Convert.ToString(row.Cells["Date"].Value);
                txtTime.Text = Convert.ToString(row.Cells["Time"].Value);
                txtName.Text = Convert.ToString(row.Cells["Contact Person"].Value);
                txtPosition.Text = Convert.ToString(row.Cells["Contact Position"].Value);
                txtContact.Text = Convert.ToString(row.Cells["Contact Person Position"].Value);
                txtInspectName.Text = Convert.ToString(row.Cells["Inspector Name"].Value);
                txtInspectContact.Text = Convert.ToString(row.Cells["Inspector Contact Information"].Value);
            }
            
        }
        private void clearselect()
        {
            dgvPermit.ClearSelection();
            foreach (DataGridViewColumn column in dgvPermit.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("Permit_ID", typeof(int));
            dt.Columns.Add("Applicant_Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Permit_Type", typeof(string));
            dt.Columns.Add("Location_Name", typeof(string));
            dt.Columns.Add("Activity", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Con_Name", typeof(string));
            dt.Columns.Add("Con_Pos", typeof(string));
            dt.Columns.Add("Con_Contact", typeof(string));
            dt.Columns.Add("Inspect_Name", typeof(string));
            dt.Columns.Add("Inspect_Contact", typeof(string));
            CRVBurial cwp = new CRVBurial();
            CrystalReportPermit crp = new CrystalReportPermit();
            
            
   
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("DummyPermit2.xml");
            TextObject id_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["id"];
            id_text.Text = ID.Text;
            TextObject AppName_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AppName"];
            AppName_text.Text = txtApplicantName.Text;
            TextObject Address_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Address"];
            Address_text.Text = txtAddress.Text;
            TextObject PermType_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["PermType"];
            PermType_text.Text = txtPermitType.Text;
            TextObject Location_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Location"];
            Location_text.Text = txtLocationName.Text;
            TextObject Act_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Activity"];
            Act_text.Text = txtActivity.Text;
            TextObject Date_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Date"];
            Date_text.Text = dtpDateApproved.Text;
            TextObject Time_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Time"];
            Time_text.Text = txtTime.Text;
            TextObject ConName_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ConName"];
            ConName_text.Text = txtName.Text;
            TextObject ConPos_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ConPos"];
            ConPos_text.Text = txtPosition.Text;
            TextObject ConCon_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ConCon"];
            ConCon_text.Text = txtContact.Text;
            TextObject InspectName_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["InspectName"];
            InspectName_text.Text = txtInspectName.Text;
            TextObject InspectCon_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["InspectCon"];
            InspectCon_text.Text = txtInspectContact.Text;
            crp.SetDataSource(ds);
            cwp.crystalReportViewer1.ReportSource = crp;
            cwp.crystalReportViewer1.Refresh();
            cwp.Show();
        }

        private void formPlazaPermits_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
    
}
