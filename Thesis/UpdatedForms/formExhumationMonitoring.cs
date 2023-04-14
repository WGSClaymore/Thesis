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
    public partial class formExhumationMonitoring : Form
    {
        public formExhumationMonitoring()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from ExhumationNewMonitoring_Tbl ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DgvEM.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void formExhumationMonitoring_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAddEM_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" insert into ExhumationNewMonitoring_Tbl values ( '"+ CbEMType.Text+"','"+ dtpEM_DateProcess.Text +"','"+dtpEM_ExTranDate.Text+"','"+txtNameRemains.Text+ "','" + txtEMCPerson.Text + "','" + txtEMCPNo.Text + "','" + txtEMAddress.Text + "','" + txtEMRelation.Text + "','" + txtEMFrom.Text + "','" + txtEMTo.Text + "','" + txtEMLotNo.Text + "','" + txtEMNicheNo.Text + "','" + txtEMLvlNo.Text + "','" + txtEMWorker.Text + "','" + txtEMWorker_ContactNo.Text + "','" + txtEM_ExAmount.Text + "','" + txtEM_ExORNo.Text + "','" + dtpEM_ExTranDate.Text + "','" + txtEM_AmrAmount.Text + "','" + txtEM_AmrORNo.Text + "','" + dtpEM_AmrDate.Text + "','" + txtEM_TranAmount.Text + "','" + txtEM_TranORNo.Text + "','" + dtpEM_TranDate.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New exhumation monitoring permit has been successfully recorded");
            Con.Close();
            populate();
            CbEMType.Text = " ";
            dtpEM_DateProcess.Text = " ";
            dtpEM_ExTranDate.Text = " ";
            txtNameRemains.Clear();
            txtEMCPerson.Clear();
            txtEMCPNo.Clear();
            txtEMAddress.Clear();
            txtEMRelation.Clear();
            txtEMFrom.Clear();
            txtEMTo.Clear();
            txtEMLotNo.Clear();
            txtEMNicheNo.Clear();
            txtEMLvlNo.Clear();
            txtEMWorker.Clear();
            txtEMWorker_ContactNo.Clear();
            txtEM_ExAmount.Clear();
            txtEM_ExORNo.Clear();
            dtpEM_ExDate.Text = "";
            txtEM_AmrAmount.Clear();
            txtEM_AmrORNo.Clear();
            dtpEM_AmrDate.Text = " ";
            txtEM_TranAmount.Clear();
            txtEM_TranORNo.Clear();
            dtpEM_TranDate.Text = "";


        }

        private void btnEditEM_Click(object sender, EventArgs e)
        {
            Con.Open();
         // SqlCommand cmd = new SqlCommand ("update ExhumationNewMonitoring_Tbl Set Date_Process='"+dtpEM_DateProcess +"',Date_ExTranDate = '"+ dtpEM_ExTranDate +"', )
        }

        private void btnDeleteEM_Click(object sender, EventArgs e)
        {
            Con.Open();
         //   string Myquery = "Delete from ExhumationNewMonitoring_Tbl where "
        }
    }
}
