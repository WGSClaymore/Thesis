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

namespace Thesis.UpdatedForms
{
    public partial class formPermitsManagement : Form
    {
        public formPermitsManagement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TFRVELK\SQLEXPRESS01;Initial Catalog=CENRO_DB_Final;Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from Permit_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvPermit.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAddPermit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Permit_Tbl values('" + txtApplicantName.Text + "', '" + txtAddress.Text + "', " +
            "'" + txtPermitType.Text + "', '" + txtLocationName.Text + "', '" + txtActivity.Text + "', '" + dtpDateApproved.Text + "', '" + txtTime.Text + "', " +
            "'" + txtName.Text + "', '" + txtPosition.Text + "', '" + txtContact.Text + "', '" + txtInspectName + "', '" + txtInspectContact + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Information Successfully Added");
            Con.Close();
            populate();
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

        private void formPermitsManagement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnEditPermit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update Permit_Tbl set Applicant_Name='" + txtApplicantName.Text + "', Address= '" + txtAddress.Text + "', " +
            "Permit_Type= '" + txtPermitType.Text + "', Location_Name='" + txtLocationName.Text + "', Activity='" + txtActivity.Text + "', Date='" + dtpDateApproved.Text + "', " +
            "Time='" + txtTime.Text + "', Con_Name='" + txtName.Text + "', Con_Pos='" + txtPosition.Text + "', Con_Contact='" + txtContact.Text + "', " +
            "Inspect_Name='" + txtInspectName.Text + "', Inspect_Contact='" + txtInspectContact.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Information Successfully Updated");
            Con.Close();
            populate();
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

        private void btnDeletePermit_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from Permit_Tbl where Applicant_Name='" + txtApplicantName.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Successfully Deleted");
            Con.Close();
            populate();
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

        private void dgvPermit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtApplicantName.Text = dgvPermit.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dgvPermit.SelectedRows[0].Cells[2].Value.ToString();
            txtPermitType.Text = dgvPermit.SelectedRows[0].Cells[3].Value.ToString();
            txtLocationName.Text = dgvPermit.SelectedRows[0].Cells[4].Value.ToString();
            txtActivity.Text = dgvPermit.SelectedRows[0].Cells[5].Value.ToString();
            dtpDateApproved.Text = dgvPermit.SelectedRows[0].Cells[6].Value.ToString();
            txtTime.Text = dgvPermit.SelectedRows[0].Cells[7].Value.ToString();
            txtName.Text = dgvPermit.SelectedRows[0].Cells[8].Value.ToString();
            txtPosition.Text = dgvPermit.SelectedRows[0].Cells[9].Value.ToString();
            txtContact.Text = dgvPermit.SelectedRows[0].Cells[10].Value.ToString();
            txtInspectName.Text = dgvPermit.SelectedRows[0].Cells[11].Value.ToString();
            txtInspectContact.Text = dgvPermit.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
