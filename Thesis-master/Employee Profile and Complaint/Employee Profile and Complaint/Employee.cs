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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
                Con.Open();
                string Myquery = "select * from EmpTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Empdgv.DataSource = ds.Tables[0];
                Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into EmpTbl values('" + EmpName.Text + "', '" + Pos.Text + "', '" + Item.Text + "', " +
                "'" + SG.Text + "', '" + Area.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                Con.Close();
                populate();
                EmpName.Clear();
                Pos.Clear();
                Item.Clear();
                SG.Clear();
                Area.Clear();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update EmpTbl set EmpName='" + EmpName.Text + "', Position='" + Pos.Text + "', SG/Step='"
                + SG.Text + "' Area of Assignment='" + Area.Text + "' where Item No.='" + Item.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Information Successfully Updated");
                Con.Close();
                populate();
                EmpName.Clear();
                Pos.Clear();
                Item.Clear();
                SG.Clear();
                Area.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                Con.Open();
                string Myquery = "delete from EmpTbl where Item No.='" + Item.Text + "'";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Deleted");
                Con.Close();
                populate();
                EmpName.Clear();
                Pos.Clear();
                Item.Clear();
                SG.Clear();
                Area.Clear();
        }

        private void Empdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpName.Text = Empdgv.SelectedRows[0].Cells[0].Value.ToString();
            Pos.Text = Empdgv.SelectedRows[0].Cells[1].Value.ToString();
            Item.Text = Empdgv.SelectedRows[0].Cells[2].Value.ToString();
            SG.Text = Empdgv.SelectedRows[0].Cells[3].Value.ToString();
            Area.Text = Empdgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
    }
}
