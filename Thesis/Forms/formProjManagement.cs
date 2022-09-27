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
    public partial class formProjManagement : Form
    {
        public formProjManagement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from ProjManagement";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Projdgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void formProjManagement_Load(object sender, EventArgs e)
        {
            populate();
            fillempassign();
        }
        void fillempassign()
        {
            string query = "select * from EmpTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("EmpName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                EmpAssign.ValueMember = "EmpName";
                EmpAssign.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into ProjManagement values('" + textBox1.Text + "', '" + ProjName.Text + "', '" + ProjType.Text + "', " +
            "'" + ProjHead.Text + "', '" + EmpAssign.SelectedValue.ToString() + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Successfully Added");
            Con.Close();
            populate();
            textBox1.Clear();
            ProjName.Clear();
            ProjType.Clear();
            ProjHead.Clear();
            EmpAssign.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ProjManagement set ProjName='" + ProjName.Text + "', Proj type='" + ProjType.Text + "', " +
            "Proj head='" + ProjHead.Text + "', Emp assign='" + EmpAssign.SelectedValue.ToString() + "' where Proj no.='" + textBox1.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Successfully Updated");
            Con.Close();
            populate();
            textBox1.Clear();
            ProjName.Clear();
            ProjType.Clear();
            ProjHead.Clear();
            EmpAssign.Text = "";
        }

        private void Projdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Projdgv.SelectedRows[0].Cells[0].Value.ToString();
            ProjName.Text = Projdgv.SelectedRows[0].Cells[1].Value.ToString();
            ProjType.Text = Projdgv.SelectedRows[0].Cells[2].Value.ToString();
            ProjHead.Text = Projdgv.SelectedRows[0].Cells[3].Value.ToString();
            EmpAssign.SelectedValue = Projdgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ProjManagement where Proj no.='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Successfully Deleted");
            Con.Close();
            populate();
            textBox1.Clear();
            ProjName.Clear();
            ProjType.Clear();
            ProjHead.Clear();
            EmpAssign.Text = "";
        }
    }
}
