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

namespace Thesis.UpdatedForms
{
    public partial class formComplaintStatus : Form
    {
        SqlConnection Con;
        public formComplaintStatus()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
       // SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TFRVELK\SQLEXPRESS01;Initial Catalog=cenroDBFinal;Integrated Security=True");
        //  SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        void populateReceived()
        {
            Con.Open();
            string Myquery = "select * from ReceivedComp_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvComplaint.DataSource = ds.Tables[0];
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string Myquery = "select * from Complaint_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvFinal.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void formComplaintStatus_Load(object sender, EventArgs e)
        {
            populate();
            populateReceived();
        }

        private void dgvComplaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompName.Text = dgvComplaint.SelectedRows[0].Cells[1].Value.ToString();
            Status.Text = dgvComplaint.SelectedRows[0].Cells[2].Value.ToString();
            Address.Text = dgvComplaint.SelectedRows[0].Cells[3].Value.ToString();
            Nature.Text = dgvComplaint.SelectedRows[0].Cells[4].Value.ToString();
            TelNo.Text = dgvComplaint.SelectedRows[0].Cells[5].Value.ToString();
            Desc.Text = dgvComplaint.SelectedRows[0].Cells[6].Value.ToString();
            Date.Text = dgvComplaint.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void dgvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompName.Text = dgvFinal.SelectedRows[0].Cells[1].Value.ToString();
            Status.Text = dgvFinal.SelectedRows[0].Cells[2].Value.ToString();
            Address.Text = dgvFinal.SelectedRows[0].Cells[3].Value.ToString();
            Nature.Text = dgvFinal.SelectedRows[0].Cells[4].Value.ToString();
            TelNo.Text = dgvFinal.SelectedRows[0].Cells[5].Value.ToString();
            Desc.Text = dgvFinal.SelectedRows[0].Cells[6].Value.ToString();
            Date.Text = dgvFinal.SelectedRows[0].Cells[7].Value.ToString();
            dtpUpdate.Text = dgvFinal.SelectedRows[0].Cells[8].Value.ToString();
            Action.Text = dgvFinal.SelectedRows[0].Cells[9].Value.ToString();
            Remarks.Text = dgvFinal.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Complaint_Tbl values('" + CompName.Text + "', '" + Status.Text + "', " +
            "'" + Address.Text + "', '" + Nature.Text + "', '" + TelNo.Text + "', '" + Desc.Text + "', '" + Date.Text + "', '" + dtpUpdate.Text + "', " +
            "'" + Action.Text + "', '" + Remarks.Text + "')", Con);
            string Myquery = "delete from ReceivedComp_Tbl where Complaintant='" + CompName.Text + "'";
            SqlCommand cmd2 = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Complaint successfully updated");
            Con.Close();
            populate();
            populateReceived();
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";
            dtpUpdate.Text = "";
            Action.Clear();
            Remarks.Clear();
        }

        private void btnEditComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update Complaint_Tbl set Complaintant='" + CompName.Text + "', Status= '" + Status.Text + "', " +
            "Address= '" + Address.Text + "', Nature_of_Complaint='" + Nature.Text + "', Telephone_No='" + TelNo.Text + "', Description='" + Desc.Text + "', " +
            "Date_Submitted='" + Date.Text + "', Date_Resolved='" + dtpUpdate.Text + "', Actions_Taken='" + Action.Text + "', Remarks='" + Remarks.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint successfully edited");
            Con.Close();
            populate();
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";
            dtpUpdate.Text = "";
            Action.Clear();
            Remarks.Clear();
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from Complaint_Tbl where Complaintant='" + CompName.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Successfully Deleted");
            Con.Close();
            populate();
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";
            dtpUpdate.Text = "";
            Action.Clear();
            Remarks.Clear();
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
