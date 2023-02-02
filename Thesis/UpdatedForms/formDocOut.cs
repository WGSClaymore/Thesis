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
    public partial class formDocOut : Form
    {
        public formDocOut()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from DocOut_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDocOut.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into DocOut_Tbl values ('" + txtDocTitle.Text + "','" + dtpDate.Text + "','" + txtRelBy.Text + "','" + txtRelTo.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Document Logged");
            Con.Close();
            populate();
            txtDocTitle.Clear();
            txtRelBy.Clear();
            txtRelTo.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update DocOut_Tbl set Document_Title='" + txtDocTitle.Text + "', Date='" + dtpDate.Text + "', " +
            "Released_By='" + txtRelBy.Text + "', Released_To='" + txtRelTo.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Document Log Updated");
            Con.Close();
            populate();
            txtDocTitle.Clear();
            txtRelBy.Clear();
            txtRelTo.Clear();
        }

        private void formDocOut_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgvDocOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDocTitle.Text = dgvDocOut.SelectedRows[0].Cells[1].Value.ToString();
            dtpDate.Text = dgvDocOut.SelectedRows[0].Cells[2].Value.ToString();
            txtRelBy.Text = dgvDocOut.SelectedRows[0].Cells[3].Value.ToString();
            txtRelTo.Text = dgvDocOut.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
