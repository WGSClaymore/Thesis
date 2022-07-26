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

namespace Employee_Profile_and_Complaint
{
    public partial class Complaint : Form
    {
        public Complaint()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        private object myDisableValue;

        void populate()
        {
                Con.Open();
                string Myquery = "select * from ComplaintTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Complaintdgv.DataSource = ds.Tables[0];
                Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into ComplaintTbl values('" + ID.Text + "', '" + CompType.Text + "', '" + dtp1.Text + "', " +
            "'" + SubBy.Text + "', '" + Status.Text + "', '" + DateRes.Text + "', '" + ActTaken.Text + "', '"+Desc.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Successfully Added");
            Con.Close();
            populate();
            ID.Clear();
            CompType.Text = "";
            dtp1.Text = "";
            SubBy.Clear();
            Status.Text = ""; 
            DateRes.Clear();
            ActTaken.Clear();
            Desc.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ComplaintTbl set Complaint Type='" + CompType.Text + "', Date Submitted='" + dtp1.Text + "', " +
            "Submitted By='" + SubBy.Text + "', Status = '"+Status.Text+"', Date Resolved = '"+DateRes.Text+"', Action/s Taken = '"+ActTaken.Text+"', " +
            "Description = '"+Desc.Text+"' where ComplaintID ='" + ID.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Information Successfully Updated");
            Con.Close();
            populate();
            ID.Clear();
            CompType.Text = "";
            dtp1.Text = "";
            SubBy.Clear();
            Status.Text = "";
            DateRes.Clear();
            ActTaken.Clear();
            Desc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ComplaintTbl where ComplaintID ='" + ID.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Successfully Deleted");
            Con.Close();
            populate();
            ID.Clear();
            CompType.Text = "";
            dtp1.Text = "";
            SubBy.Clear();
            Status.Text = "";
            DateRes.Clear();
            ActTaken.Clear();
            Desc.Clear();
        }

        private void Complaintdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = Complaintdgv.SelectedRows[0].Cells[0].Value.ToString();
            CompType.Text = Complaintdgv.SelectedRows[0].Cells[1].Value.ToString();
            dtp1.Text = Complaintdgv.SelectedRows[0].Cells[2].Value.ToString();
            SubBy.Text = Complaintdgv.SelectedRows[0].Cells[3].Value.ToString();
            Status.Text = Complaintdgv.SelectedRows[0].Cells[4].Value.ToString();
            DateRes.Text = Complaintdgv.SelectedRows[0].Cells[3].Value.ToString();
            ActTaken.Text = Complaintdgv.SelectedRows[0].Cells[4].Value.ToString();
            Desc.Text = Complaintdgv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void CompType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompType.SelectedValue == myDisableValue)
                Status.Enabled = false;
            else
                Status.Enabled = true;
        }
    }
}
