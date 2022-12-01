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

namespace Thesis.UpdatedForms
{
    public partial class formDocIn : Form
    {
        public formDocIn()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TFRVELK\SQLEXPRESS01;Initial Catalog=CENRO_DB_Final;Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from DocIn_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDocIn.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void dgvDocIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDocTitle.Text = dgvDocIn.SelectedRows[0].Cells[1].Value.ToString();
            dtpDate.Text = dgvDocIn.SelectedRows[0].Cells[2].Value.ToString();
            txtSource.Text = dgvDocIn.SelectedRows[0].Cells[3].Value.ToString();
            txtRecieved.Text = dgvDocIn.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into DocIn_Tbl values ('" + txtDocTitle.Text + "','" + dtpDate.Text + "','" + txtSource.Text + "','" + txtRecieved.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Document Logged");
            Con.Close();
            populate();
            txtDocTitle.Clear();
            txtRecieved.Clear();
            txtSource.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update DocIn_Tbl set Document_Title='" + txtDocTitle.Text + "', Date='" + dtpDate.Text + "', " +
            "Source='" + txtSource.Text + "', Recieved_By='" + txtRecieved.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Document Log Updated");
            Con.Close();
            populate();
            txtDocTitle.Clear();
            txtRecieved.Clear();
            txtSource.Clear();
        }

        private void formDocIn_Load(object sender, EventArgs e)
        {

        }

        private void txtDocTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
