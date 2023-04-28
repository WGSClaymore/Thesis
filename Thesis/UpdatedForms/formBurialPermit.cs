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
using System.Configuration;

namespace Thesis.UpdatedForms
{
    public partial class formBurialPermit : Form
    {
        SqlConnection Con;
        public formBurialPermit()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
        void populate()
        {
            Con.Open();
             string Myquery = "SELECT Name, Address, DOB AS 'Date of Birth', POB AS 'Place of Birth', DOD AS 'Date of Death', ATD AS 'Age of Time of Death', COD AS 'Cause of Death', " +
                 "Contact_Person AS 'Contact Person', Contact_Number AS 'Contact Number', Relation, DateFiling AS 'Date of Filing', DateInterment AS 'Date of Interment', " +
                 "Burial_Place AS 'Place of Burial', LotNo AS 'Lot Number', NicheNo AS 'Niche Number', LvlNo AS 'Level Number', Burial_Fee AS 'Burial Fee', Amount, OR_NO AS" +
                 " 'Order Receipt Number', TransDate AS 'Date of Transfer' FROM Burial_Tbl";           
           // string Myquery = "SELECT * FROM Burial_Tbl";
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
            SqlCommand cmd = new SqlCommand("insert into Burial_Tbl values ('"+ txtBurialName.Text + "','" + txtBurialAddress.Text + "','" + dtpBurialDOB.Text + "','" + txtBurialPOB.Text + "','" + dtpBurialDateDeath.Text + "','" + txtBurialAgeDeath.Text + "','" + txtBurialCOD.Text + "','" + txtBurialCPerson.Text + "','" + txtBurialCPNo.Text + "','" + txtBurialRelation.Text + "','" + dtpBurialDOF.Text + "','" + dtpBurialDOI.Text + "','" + txtBurialPlace.Text + "','" + txtBurialLotNo.Text + "','" + txtBurialNicheNo.Text + "','" + txtBurialLvlNo.Text + "','" + txtBurialFee.Text + "','" + txtBurialAmount.Text + "','" + txtBurialORNo.Text + "','" + dtpBurialTransDate.Text + "' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New burial permit has been added");
            Con.Close();
            populate();
            txtBurialName.Clear();
            txtBurialAddress.Clear();
            txtBurialAgeDeath.Clear();
            txtBurialCPerson.Clear();
            txtBurialCPNo.Clear();
            txtBurialRelation.Clear();
            txtBurialPOB.Clear();
            txtBurialLotNo.Clear();
            txtBurialNicheNo.Clear();
            txtBurialLvlNo.Clear();
            txtBurialFee.Clear();
            txtBurialAmount.Clear();
            txtBurialORNo.Clear();;
        }

        private void btnEditBurial_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update Burial_Tbl set Name='" + txtBurialName.Text + "', " +
                "Address= '" + txtBurialAddress.Text + "', DOB='" + dtpBurialDOB.Text + "', " +
                "POB='" + txtBurialPOB.Text + "',ATD='" + txtBurialAgeDeath.Text + "', " +
                "COD='" + txtBurialCOD.Text + "',Contact_Person='" + txtBurialCPerson.Text + "'," +
                "Contact_Number='" + txtBurialCPNo.Text + "',Relation='" + txtBurialRelation.Text + "'," +
                "Date_of_Filing='" + dtpBurialDOF.Text + "',Date_of_Interment='" + dtpBurialDOI.Text + "'," +
                "Place_of_Burial='" + txtBurialPOB.Text + "',LotNo='" + txtBurialLotNo.Text + "',NicheNo='" + txtBurialNicheNo.Text + "'," +
                "LvlNo='" + txtBurialLvlNo.Text + "',Burial_Fee='" + txtBurialFee.Text + "',Amount='" + txtBurialAmount.Text + "'," +
                "OR_No='" + txtBurialORNo.Text + "',Date='" + dtpBurialTransDate.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Burial permit has been edited");
            Con.Close();
            populate();
        }

    

        private void btnDeleteBurial_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "Delete From Burial_Tbl where Name= '" + txtBurialName + "' ";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Burial permit successfully deleted");
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
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("Burial_ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("DOB", typeof(string));
            dt.Columns.Add("POB", typeof(string));
            dt.Columns.Add("DOD", typeof(string));
            dt.Columns.Add("ATD", typeof(string));
            dt.Columns.Add("COD", typeof(string));
            dt.Columns.Add("Contact_Person", typeof(string));
            dt.Columns.Add("Contact_Number", typeof(string));
            dt.Columns.Add("Relation", typeof(string));
            dt.Columns.Add("DateFiling", typeof(string));
            dt.Columns.Add("DateInterment", typeof(string));
            dt.Columns.Add("Burial_Place", typeof(string));
            dt.Columns.Add("LotNo", typeof(string));
            dt.Columns.Add("NicheNo", typeof(string));
            dt.Columns.Add("LvlNo", typeof(string));
            dt.Columns.Add("Burial_Fee", typeof(string));
            dt.Columns.Add("Amount", typeof(string));
            dt.Columns.Add("OR_No", typeof(string));
            dt.Columns.Add("TransDate", typeof(string));

            CRBurial CRB = new CRBurial();
            CRVBurial CRV = new CRVBurial();

            /*
            foreach (DataGridViewRow dgv in dgvBurial.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value,
                    dgv.Cells[10].Value, dgv.Cells[11].Value, dgv.Cells[12].Value, dgv.Cells[13].Value, dgv.Cells[14].Value, dgv.Cells[15].Value, dgv.Cells[16].Value, dgv.Cells[17].Value, dgv.Cells[18].Value, dgv.Cells[19].Value, dgv.Cells[20].Value);
            }
            */
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("BurialPermit.xml");

            TextObject Name_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["Name"];
            Name_text.Text= txtBurialName.Text;
            TextObject Address_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["Address"];
            Address_text.Text = txtBurialAddress.Text;
            TextObject DOB_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["DateBirth"];
            DOB_text.Text = dtpBurialDOB.Text;
            TextObject POB_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["PlaceBirth"];
            POB_text.Text = txtBurialPOB.Text;
            TextObject DOD_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["DateDeath"];
            DOD_text.Text = dtpBurialDateDeath.Text;
            TextObject ATD_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["AgeDeath"];
            ATD_text.Text = txtBurialAgeDeath.Text;
            TextObject COD_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["CauseDeath"];
            COD_text.Text = txtBurialCOD.Text;
            TextObject ContactPerson_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["ContactPerson"];
            ContactPerson_text.Text = txtBurialCPerson.Text;
            TextObject ContactNumber_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["ContactNo"];
            ContactNumber_text.Text = txtBurialCPNo.Text;
            TextObject Relation_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["Relation"];
            Relation_text.Text = txtBurialRelation.Text;
            TextObject DateFiling_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["DateFiling"];
            DateFiling_text.Text = dtpBurialDOF.Text;
            TextObject DateInterment_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["DateInterment"];
            DateInterment_text.Text = dtpBurialDOI.Text;
            TextObject BurialPlace_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["PlaceBurial"];
            BurialPlace_text.Text = txtBurialPlace.Text;
            TextObject LotNo_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["LotNo"];
            LotNo_text.Text = txtBurialLotNo.Text;
            TextObject NicheNo_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["NicheNo"];
            NicheNo_text.Text = txtBurialNicheNo.Text;
            TextObject LevelNo_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["LevelNo"];
            LevelNo_text.Text = txtBurialLvlNo.Text;
            TextObject BurialFee_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["BurialFee"];
            BurialFee_text.Text = txtBurialFee.Text;
            TextObject Amount_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["Amount"];
            Amount_text.Text = txtBurialAmount.Text;
            TextObject ORNo_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["ORNo"];
            ORNo_text.Text = txtBurialORNo.Text;
            TextObject TranDate_text = (TextObject)CRB.ReportDefinition.Sections["Section3"].ReportObjects["TranDate"];
            TranDate_text.Text = dtpBurialTransDate.Text;


            CRV.crystalReportViewer1.ReportSource = CRB;
            CRV.crystalReportViewer1.Refresh();
            CRV.Show();
        }

        private void dgvBurial_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBurial.Rows.Count)
            {
                DataGridViewRow row = dgvBurial.Rows[e.RowIndex];
                txtBurialName.Text = Convert.ToString(row.Cells["Name"].Value);
                txtBurialAddress.Text = Convert.ToString(row.Cells["Address"].Value);
                dtpBurialDOB.Text = Convert.ToString(row.Cells["Date of Birth"].Value);
                txtBurialPOB.Text = Convert.ToString(row.Cells["Place of Birth"].Value);
                dtpBurialDateDeath.Text = Convert.ToString(row.Cells["Date of Death"].Value);
                txtBurialAgeDeath.Text = Convert.ToString(row.Cells["Age of Time of Death"].Value);
                txtBurialCOD.Text = Convert.ToString(row.Cells["Cause of Death"].Value);
                txtBurialCPerson.Text = Convert.ToString(row.Cells["Contact Person"].Value);
                txtBurialCPNo.Text = Convert.ToString(row.Cells["Contact Number"].Value);
                txtBurialRelation.Text = Convert.ToString(row.Cells["Relation"].Value);
                dtpBurialDOF.Text = Convert.ToString(row.Cells["Date of Filing"].Value);
                dtpBurialDOI.Text = Convert.ToString(row.Cells["Date of Interment"].Value);
                txtBurialPlace.Text = Convert.ToString(row.Cells["Place of Burial"].Value);
                txtBurialLotNo.Text = Convert.ToString(row.Cells["Lot Number"].Value);
                txtBurialNicheNo.Text = Convert.ToString(row.Cells["Niche Number"].Value);
                txtBurialLvlNo.Text = Convert.ToString(row.Cells["Level Number"].Value);
                txtBurialFee.Text = Convert.ToString(row.Cells["Burial Fee"].Value);
                txtBurialAmount.Text = Convert.ToString(row.Cells["Amount"].Value);
                txtBurialORNo.Text = Convert.ToString(row.Cells["Order Receipt Number"].Value);
                dtpBurialTransDate.Text = Convert.ToString(row.Cells["Date of Transfer"].Value);
            }
        }
    }
}
