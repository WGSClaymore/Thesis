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
 //       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
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
            SqlCommand cmd = new SqlCommand("insert into ComplaintTbl values('" + CompType.Text + "', '" + dtp1.Text + "', " +
            "'" + SubBy.Text + "','" + Desc.Text + "', '" + Status.Text + "','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text +"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Added");
            Con.Close();
            populate();
            CompType.Text = "";
            dtp1.Text = "";
            SubBy.Clear();
            Desc.Clear();
            Status.Text = "";
        }
        private void Complaintdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompType.Text = Complaintdgv.SelectedRows[0].Cells[1].Value.ToString();
            dtp1.Text = Complaintdgv.SelectedRows[0].Cells[2].Value.ToString();
            SubBy.Text = Complaintdgv.SelectedRows[0].Cells[3].Value.ToString();
            Desc.Text = Complaintdgv.SelectedRows[0].Cells[4].Value.ToString();
            Status.Text = Complaintdgv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ComplaintTbl where Comp_Type ='" + CompType.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Deleted");
            Con.Close();
            populate();
            CompType.Text = "";
            dtp1.Text = "";
            SubBy.Clear();
            Desc.Clear();
            Status.Text = "";
        }

        private void formComplaint_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ComplaintTbl set Date_Submitted='" + dtp1.Text + "', Submitted_By='" + SubBy.Text + "', " +
            "Description = '" + Desc.Text + "', Status= '" + Status.Text + "'  where Complaint_Type ='" + CompType.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint Information Successfully Updated");
            Con.Close();
            populate();
            CompType.Text = "";
            dtp1.Text = "";
            SubBy.Clear();
            Desc.Clear();
            Status.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
