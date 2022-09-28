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
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from UsersTbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Users.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void formUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into UsersTbl values('"+Fullname.Text+"', '"+Username.Text+"', '" + Password.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New User Successfully Added");
            Con.Close();
            populate();
            Fullname.Clear();
            Username.Clear();
            Password.Clear();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update UsersTbl set Username='" + Username.Text + "', Password='" + Password.Text + "' " +
            "where Fullname ='" + Fullname.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Information Successfully Updated");
            Con.Close();
            populate();
            Fullname.Clear();
            Username.Clear();
            Password.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from UsersTbl where Fullname ='" + Fullname.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Deleted");
            Con.Close();
            populate();
            Fullname.Clear();
            Username.Clear();
            Password.Clear();
        }

        private void Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fullname.Text = Users.SelectedRows[0].Cells[0].Value.ToString();
            Username.Text = Users.SelectedRows[0].Cells[1].Value.ToString();
            Password.Text = Users.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
