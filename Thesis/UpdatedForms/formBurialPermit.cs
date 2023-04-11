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
using System.Windows;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Thesis.UpdatedForms
{
    public partial class formBurialPermit : Form
    {
        public formBurialPermit()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from BurialPermit_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBurial.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void formBurialPermit_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAddBurial_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into BurialPermit_Tbl values ('"+txtBurialName.Text+ "','" + txtBurialAddress.Text + "','" + dtpBurialDOB.Text + "','" + txtBurialPOB.Text + "','" + dtpBurialDateDeath.Text + "','" + txtBurialAgeDeath.Text + "','" + txtBurialCOD.Text + "','" + txtBurialCPerson.Text + "','" + txtBurialCPNo.Text + "','" + txtBurialRelation.Text + "','" + dtpBurialDOF.Text + "','" + dtpBurialDOI.Text + "','" + txtBurialPlace.Text + "','" + txtBurialLotNo.Text + "','" + txtBurialNicheNo.Text + "','" + txtBurialLvlNo.Text + "','" + txtBurialFee.Text + "','" + txtBurialAmount.Text + "','" + txtBurialORNo.Text + "','" + dtpBurialTransDate.Text + "' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Permit has been added");
            Con.Close();
            populate();
            txtBurialName.Clear();
            txtBurialAddress.Clear();
            dtpBurialDOB.Text = " ";
            dtpBurialDateDeath.Text = " ";
            txtBurialAgeDeath.Clear();
            txtBurialCPerson.Clear();
            txtBurialCPNo.Clear();
            txtBurialRelation.Clear();
            dtpBurialDOF.Text = " ";
            dtpBurialDOI.Text = " ";
            txtBurialPOB.Clear();
            txtBurialLotNo.Clear();
            txtBurialNicheNo.Clear();
            txtBurialLvlNo.Clear();
            txtBurialFee.Clear();
            txtBurialAmount.Clear();
            txtBurialORNo.Clear();
            dtpBurialTransDate.Text = " ";
        }

        private void btnEditBurial_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update BurialPermit_Tbl set Name='" + txtBurialName.Text + "', " +
                "Address= '" + txtBurialAddress.Text + "', DOB='" + dtpBurialDOB.Text + "', " +
                "POB='" + txtBurialPOB.Text + "',ATD='" + txtBurialAgeDeath.Text + "', " +
                "COD='" + txtBurialCOD.Text + "',Contact_Person='" + txtBurialCPerson.Text + "'," +
                "Contact_Number='" + txtBurialCPNo.Text + "',Relation='" + txtBurialRelation.Text + "'," +
                "Date_of_Filing='" + dtpBurialDOF.Text + "',Date_of_Interment='" + dtpBurialDOI.Text + "'," +
                "Place_of_Burial='" + txtBurialPOB.Text + "',LotNo='" + txtBurialLotNo.Text + "',NicheNo='" + txtBurialNicheNo.Text + "'," +
                "LvlNo='" + txtBurialLvlNo.Text + "',Burial_Fee='" + txtBurialFee.Text + "',Amount='" + txtBurialAmount.Text + "'," +
                "OR_No='" + txtBurialORNo.Text + "',Date='" + dtpBurialTransDate.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit has been updated");
            Con.Close();
            populate();
        }

        private void dgvBurial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBurialName.Text = dgvBurial.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void btnDeleteBurial_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "Delete From BurialPermit_Tbl where Name= '" + txtBurialName + "' ";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Permit Successfully Deleted");
            Con.Close();
            populate();
            txtBurialName.Clear();
            txtBurialAddress.Clear();
            dtpBurialDOB.Text = "";
            dtpBurialDateDeath.Text = "";
            txtBurialAgeDeath.Clear();
            txtBurialCPerson.Clear();
            txtBurialCPNo.Clear();
            txtBurialRelation.Clear();
            dtpBurialDOF.Text = "";
            dtpBurialDOI.Text = "";
            txtBurialPOB.Clear();
            txtBurialLotNo.Clear();
            txtBurialNicheNo.Clear();
            txtBurialLvlNo.Clear();
            txtBurialFee.Clear();
            txtBurialAmount.Clear();
            txtBurialORNo.Clear();
            dtpBurialTransDate.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
