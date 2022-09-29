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
    public partial class formPermit : Form
    {
        public formPermit()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from Permit2";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Permitdgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void formPermit_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Permit2 values('" + PermName.Text + "', '" + dtp3.Text + "', '" + Purpose.Text + "', '" + comboBox1.Text + "', " +
            "'" + Rev.Text + "', '" + Note.Text + "', '" + dtp4.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Information Successfully Added");
            Con.Close();
            populate();
           
            PermName.Clear();
            dtp3.Text = "";
            Purpose.Text = "";
            comboBox1.Text = "";
            Rev.Clear();
            Note.Clear();
            dtp4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update Permit2 set Name='" + PermName.Text + "', Date_Issued='" + dtp3.Text + "', " +
            "Application_Purpose='" + Purpose.Text + "', Type_of_Permit='" + comboBox1.Text + "', Reviewed_By='" + Rev.Text + "', " +
            "Noted_By='" + Note.Text + "', Date_Approved='" + dtp4.Text +"'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Information Successfully Updated");
            Con.Close();
            populate();
            PermName.Clear();
            dtp3.Text = "";
            Purpose.Text = "";
            comboBox1.Text = "";
            Rev.Clear();
            Note.Clear();
            dtp4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from Permit2 where Name='" + PermName.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Successfully Deleted");
            Con.Close();
            populate();
            PermName.Clear();
            dtp3.Text = "";
            Purpose.Text = "";
            comboBox1.Text = "";
            Rev.Clear();
            Note.Clear();
            dtp4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formPermit home = new formPermit();
            home.Show();
            this.Hide();
        }

        private void Permitdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            PermName.Text = Permitdgv.SelectedRows[0].Cells[1].Value.ToString();
            dtp3.Text = Permitdgv.SelectedRows[0].Cells[2].Value.ToString();
            Purpose.Text = Permitdgv.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = Permitdgv.SelectedRows[0].Cells[4].Value.ToString();
            Rev.Text = Permitdgv.SelectedRows[0].Cells[5].Value.ToString();
            Note.Text = Permitdgv.SelectedRows[0].Cells[6].Value.ToString();
            dtp4.Text = Permitdgv.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
