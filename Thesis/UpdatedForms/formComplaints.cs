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
    public partial class formComplaints : Form
    {
        SqlConnection Con;
        public formComplaints()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
       
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT RCmplt_ID AS 'Complaint ID' ,Complaintant AS 'Complaintant', " +
                "Status, Address, Nature_Of_Complaint AS 'Nature of Complaint', Telephone_No AS 'Telephone Number'," +
                " Description, Date_Submitted AS 'Date Submitted' FROM ReceivedComp_Tbl";    
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvComplaint.DataSource = ds.Tables[0];
            Con.Close();
        }
        void cleartext()
        {
            lblComplaintIDEntry.Text = "";
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";

        }
        private void formComplaints_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into ReceivedComp_Tbl values('" + CompName.Text + "', '" + Status.Text + "', " +
            "'" + Address.Text + "', '" + Nature.Text + "', '" + TelNo.Text + "', '" + Desc.Text + "', '" + Date.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint information successfully added");
            Con.Close();
            populate();
            cleartext();
        }

        private void btnEditComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ReceivedComp_Tbl set Complaintant='" + CompName.Text + "', Status= '" + Status.Text + "', " +
            "Address= '" + Address.Text + "', Nature_of_Complaint='" + Nature.Text + "', Telephone_No='" + TelNo.Text + "', Description='" + Desc.Text + "', " +
            "Date_Submitted='" + Date.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint information successfully edited");
            Con.Close();
            populate();
            cleartext();
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "DELETE FROM ReceivedComp_Tbl WHERE RCmplt_ID='" + lblComplaintIDEntry.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint information successfully deleted");
            Con.Close();
            populate();
            cleartext();
        }

        private void dgvComplaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvComplaint.Rows.Count)
            {
                DataGridViewRow row = dgvComplaint.Rows[e.RowIndex];

                lblComplaintIDEntry.Text = Convert.ToString(row.Cells["Complaint ID"].Value);
                CompName.Text = Convert.ToString(row.Cells["Complaintant"].Value);
                Status.Text = Convert.ToString(row.Cells["Status"].Value);
                Address.Text = Convert.ToString(row.Cells["Address"].Value);
                Nature.Text = Convert.ToString(row.Cells["Nature of Complaint"].Value);
                TelNo.Text = Convert.ToString(row.Cells["Telephone Number"].Value);
                Desc.Text = Convert.ToString(row.Cells["Description"].Value);
                Date.Text = Convert.ToString(row.Cells["Date Submitted"].Value);
            }
           
        }
    }
}
