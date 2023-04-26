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
        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TFRVELK\SQLEXPRESS01;Initial Catalog=cenroDBFinal;Integrated Security=True");
        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        void populate()
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
            MessageBox.Show("Complaint Information Successfully Added");
            Con.Close();
            populate();
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";
        }

        private void btnEditComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ReceivedComp_Tbl set Complaintant='" + CompName.Text + "', Status= '" + Status.Text + "', " +
            "Address= '" + Address.Text + "', Nature_of_Complaint='" + Nature.Text + "', Telephone_No='" + TelNo.Text + "', Description='" + Desc.Text + "', " +
            "Date_Submitted='" + Date.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Updated");
            Con.Close();
            populate();
            CompName.Clear();
            Status.Text = "";
            Address.Clear();
            Nature.Clear();
            TelNo.Clear();
            Desc.Clear();
            Date.Text = "";
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ReceivedComp_Tbl where Complaintant='" + CompName.Text + "'";
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
    }
}
