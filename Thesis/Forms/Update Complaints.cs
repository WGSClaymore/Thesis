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

namespace Thesis.Forms
{
    public partial class Update_Complaints : Form
    {
        public Update_Complaints()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from ComplaintTbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UpComplaintdgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Update_Complaints_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdateUp_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ComplaintTbl set Status= '"+Status.Text+"',Date_Resolved='" + dtp2.Text + "', " +
            "Actions_Taken='" + tbATUp.Text + "', Remarks='" + tbRmrkIp.Text +"'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Information Successfully Updated");
            Con.Close();
            populate();
            Status.Text = "";
            dtp2.Text = "";
            tbATUp.Clear();
            tbRmrkIp.Clear();
        }

        private void Complaintdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Status.Text = UpComplaintdgv.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
