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

namespace Thesis
{
    public partial class formComplaint : Form
    {
        public formComplaint()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
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
        private void formComplaint_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CompType_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (CompType.SelectedValue == myDisableValue)
                Status.Enabled = false;
            else
               Status.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into ComplaintTbl values('" + ID.Text + "', '" + CompType.Text + "', '" + dtp1.Text + "', " +
            "'" + SubBy.Text + "', '" + Status.Text + "', '" + DateRes.Text + "', '" + ActTaken.Text + "', '" + Desc.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Added");
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

        private void button4_Click(object sender, EventArgs e)
        {
            formMenu home = new formMenu();
            home.Show();
            this.Hide();
        }

        private void Complaintdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = Complaintdgv.SelectedRows[0].Cells[0].Value.ToString();
            CompType.Text = Complaintdgv.SelectedRows[0].Cells[1].Value.ToString();
            dtp1.Text = Complaintdgv.SelectedRows[0].Cells[2].Value.ToString();
            SubBy.Text = Complaintdgv.SelectedRows[0].Cells[3].Value.ToString();
            Status.Text = Complaintdgv.SelectedRows[0].Cells[4].Value.ToString();
            DateRes.Text = Complaintdgv.SelectedRows[0].Cells[5].Value.ToString();
            ActTaken.Text = Complaintdgv.SelectedRows[0].Cells[6].Value.ToString();
            Desc.Text = Complaintdgv.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ComplaintTbl where ComplaintID ='" + ID.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Deleted");
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

        private void formComplaint_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ComplaintTbl set Complaint_Type='" + CompType.Text + "',Date_Submitted='" + dtp1.Text + "', " +
            "Submitted_By='" + SubBy.Text + "', Status= '" + Status.Text + "', Date_Resolved= '" + DateRes.Text + "', Actions_Taken = '" + ActTaken.Text + "', " +
            "Description = '" + Desc.Text + "' where ComplaintID ='" + ID.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Updated");
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
    }
}
