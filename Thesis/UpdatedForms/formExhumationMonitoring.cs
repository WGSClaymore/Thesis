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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


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
            string Myquery = "select * from ExhumanationMonitoring_Tbl ";
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
            SqlCommand cmd = new SqlCommand(" insert into ExhumanationMonitoring_Tbl values ('" + dtpEM_DateProcess.Text +"', '"+dtpEM_ExTranDate.Text+"'," +
            "'"+txtNameRemains.Text+ "','"+dtpDOD.Text+"','" + txtEMCPerson.Text + "','" + txtEMCPNo.Text + "','" + txtEMAddress.Text + "'," +
            "'" + txtEMRelation.Text + "','" + txtEMFrom.Text + "','" + txtEMTo.Text + "','" + txtEMLotNo.Text + "','" + txtEMNicheNo.Text + "'," +
            "'" + txtEMLvlNo.Text + "','" + txtEMWorker.Text + "','" + txtEMWorker_ContactNo.Text + "','" + txtEM_ExAmount.Text + "','" + txtEM_ExORNo.Text + "'," +
            "'" + dtpEM_ExTranDate.Text + "','" + txtEM_AmrAmount.Text + "','" + txtEM_AmrORNo.Text + "','" + dtpEM_AmrDate.Text + "'," +
            "'" + txtEM_TranAmount.Text + "','" + txtEM_TranORNo.Text + "', '" + dtpEM_TranDate.Text + "', '" + CbEMType.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New exhumation monitoring permit has been successfully recorded");
            Con.Close();
            populate();
            CbEMType.Text = " ";
            dtpEM_DateProcess.Text = " ";
            dtpEM_ExTranDate.Text = " ";
            txtNameRemains.Clear();
            dtpDOD.Text = " ";
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
            dtpEM_TranDate.Text = " ";
        }

        private void btnEditEM_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand ("update ExhumanationMonitoring_Tbl Set Date_Process='" + dtpEM_DateProcess +"'," +
            "Date_ExTranDate = '"+ dtpEM_ExTranDate + "',Name_of_Remains'" + txtNameRemains.Text + "',Contact_Person='" + txtEMCPerson.Text + "'," +
            "Contact_No='" + txtEMCPNo.Text + "',Address='" + txtEMAddress.Text + "',Relation='" + txtEMRelation.Text + "',Em_From='" + txtEMFrom.Text + "'," +
            "Em_To'" + txtEMTo.Text + "',LotNo='" + txtEMLotNo.Text + "',NicheNo='" + txtEMNicheNo.Text + "',LvlNo='" + txtEMLvlNo.Text + "'," +
            "CWorker='" + txtEMWorker.Text + "',CWorkerNo='" + txtEMWorker_ContactNo.Text + "',Ex_Amount'" + txtEM_ExAmount.Text + "'," +
            "Ex_ORNo='" + txtEM_ExORNo.Text + "',Ex_Date'" + dtpEM_ExTranDate.Text + "',Amr_Amount='" + txtEM_AmrAmount.Text + "'," +
            "Amr_ORNo='" + txtEM_AmrORNo.Text + "',Amr_Date='" + dtpEM_AmrDate.Text + "',Tran_Amount='" + txtEM_TranAmount.Text + "'," +
            "Tran_ORNo='" + txtEM_TranORNo.Text + "',Tran_Date'" + dtpEM_TranDate.Text + "',Type='"+ CbEMType.Text +"'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Exhumation monitoring permit has been successfully edited");
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

        private void btnDeleteEM_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ExhumanationMonitoring_Tbl where Date_Process='" + dtpEM_DateProcess.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Exhumation monitoring permit successfully deleted");
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

        private void DgvEM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpEM_DateProcess.Text = DgvEM.SelectedRows[0].Cells[1].Value.ToString();
            dtpEM_ExTranDate.Text = DgvEM.SelectedRows[0].Cells[2].Value.ToString();
            txtNameRemains.Text = DgvEM.SelectedRows[0].Cells[3].Value.ToString();
            dtpDOD.Text= DgvEM.SelectedRows[0].Cells[4].Value.ToString();
            txtEMCPerson.Text = DgvEM.SelectedRows[0].Cells[5].Value.ToString();
            txtEMCPNo.Text = DgvEM.SelectedRows[0].Cells[6].Value.ToString();
            txtEMAddress.Text = DgvEM.SelectedRows[0].Cells[7].Value.ToString();
            txtEMRelation.Text = DgvEM.SelectedRows[0].Cells[8].Value.ToString();
            txtEMFrom.Text = DgvEM.SelectedRows[0].Cells[9].Value.ToString();
            txtEMTo.Text = DgvEM.SelectedRows[0].Cells[10].Value.ToString();
            txtEMLotNo.Text = DgvEM.SelectedRows[0].Cells[11].Value.ToString();
            txtEMNicheNo.Text = DgvEM.SelectedRows[0].Cells[12].Value.ToString();
            txtEMLvlNo.Text = DgvEM.SelectedRows[0].Cells[13].Value.ToString();
            txtEMWorker.Text = DgvEM.SelectedRows[0].Cells[14].Value.ToString();
            txtEMWorker_ContactNo.Text = DgvEM.SelectedRows[0].Cells[15].Value.ToString();
            txtEM_ExAmount.Text = DgvEM.SelectedRows[0].Cells[16].Value.ToString();
            txtEM_ExORNo.Text = DgvEM.SelectedRows[0].Cells[17].Value.ToString();
            dtpEM_ExDate.Text = DgvEM.SelectedRows[0].Cells[18].Value.ToString();
            txtEM_AmrAmount.Text = DgvEM.SelectedRows[0].Cells[19].Value.ToString();
            txtEM_AmrORNo.Text = DgvEM.SelectedRows[0].Cells[20].Value.ToString();
            dtpEM_AmrDate.Text = DgvEM.SelectedRows[0].Cells[21].Value.ToString();
            txtEM_TranAmount.Text = DgvEM.SelectedRows[0].Cells[22].Value.ToString();
            txtEM_TranORNo.Text = DgvEM.SelectedRows[0].Cells[23].Value.ToString();
            CbEMType.Text = DgvEM.SelectedRows[0].Cells[24].Value.ToString();


        }

        private void btnPrintEM_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date_Process", typeof(string));
            dt.Columns.Add("Date_ExTranDate", typeof(string));
            dt.Columns.Add("Name_of_Remains", typeof(string));
            dt.Columns.Add("DOD", typeof(string));
            dt.Columns.Add("Contact_Person", typeof(string));
            dt.Columns.Add("Contact_No", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Relation", typeof(string));
            dt.Columns.Add("Em_From", typeof(string));
            dt.Columns.Add("Em_To", typeof(string));
            dt.Columns.Add("LotNo", typeof(string));
            dt.Columns.Add("NicheNo", typeof(string));
            dt.Columns.Add("LvlNo", typeof(string));
            dt.Columns.Add("CWorker", typeof(string));
            dt.Columns.Add("CWorkerNo", typeof(string));
            dt.Columns.Add("Ex_Amount", typeof(string));
            dt.Columns.Add("Ex_ORNo", typeof(string));
            dt.Columns.Add("Ex_Date", typeof(string));
            dt.Columns.Add("Amr_Amount", typeof(string));
            dt.Columns.Add("Amr_ORNo", typeof(string));
            dt.Columns.Add("Amr_Date", typeof(string));
            dt.Columns.Add("Tran_Amount", typeof(string));
            dt.Columns.Add("Tran_ORNo", typeof(string));
            dt.Columns.Add("Tran_Date", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            CrystalViewerMonitoring cmp = new CrystalViewerMonitoring();
            crNewMonitor crp = new crNewMonitor();

            foreach (DataGridViewRow dgv in DgvEM.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value,
                    dgv.Cells[2].Value, dgv.Cells[3].Value,
                    dgv.Cells[4].Value, dgv.Cells[5].Value,
                    dgv.Cells[6].Value, dgv.Cells[7].Value,
                    dgv.Cells[8].Value, dgv.Cells[9].Value,
                    dgv.Cells[10].Value, dgv.Cells[11].Value,
                    dgv.Cells[12].Value, dgv.Cells[13].Value,
                    dgv.Cells[14].Value, dgv.Cells[15].Value,
                    dgv.Cells[16].Value, dgv.Cells[17].Value,
                    dgv.Cells[18].Value, dgv.Cells[19].Value,
                    dgv.Cells[20].Value, dgv.Cells[21].Value,
                    dgv.Cells[22].Value, dgv.Cells[23].Value,
                    dgv.Cells[24].Value, dgv.Cells[25].Value);

            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("ExhumnationNewMonitoring.xml");
            TextObject Type_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Type"];
            Type_text.Text = CbEMType.Text;
            TextObject DateProcess_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["DateProcess"];
            DateProcess_text.Text = dtpEM_DateProcess.Text;
            TextObject DateExTran_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["DateExTran"];
            DateExTran_text.Text = dtpEM_ExTranDate.Text;
            TextObject NameRemains_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["NameRemains"];
            NameRemains_text.Text = txtNameRemains.Text;
            TextObject DOD_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["DOD"];
            DOD_text.Text = dtpDOD.Text;
            TextObject CPerson_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CPerson"];
            CPerson_text.Text = txtEMCPerson.Text;
            TextObject CPersonNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CPersonNo"];
            CPersonNo_text.Text = txtEMCPNo.Text;
            TextObject Address_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Address"];
            Address_text.Text = txtEMAddress.Text;
            TextObject Relation_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Relation"];
            Relation_text.Text = txtEMRelation.Text;
            TextObject From_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["From"];
            From_text.Text = txtEMFrom.Text;
            TextObject To_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["To"];
            To_text.Text = txtEMTo.Text;
            TextObject LotNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["LotNo"];
            LotNo_text.Text = txtEMLotNo.Text;
            TextObject NicheNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["NicheNo"];
            NicheNo_text.Text = txtEMNicheNo.Text;
            TextObject LvlNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["LvlNo"];
            LvlNo_text.Text = txtEMLvlNo.Text;
            TextObject CWorker_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CWorker"];
            CWorker_text.Text = txtEMWorker.Text;
            TextObject CWorkerNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CWorkerNo"];
            CWorkerNo_text.Text = txtEMWorker_ContactNo.Text;
            TextObject ExAmount_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ExAmount"];
            ExAmount_text.Text = txtEM_ExAmount.Text;
            TextObject ExORNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ExORNo"];
            ExORNo_text.Text = txtEM_ExORNo.Text;
            TextObject ExDate_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ExDate"];
            ExDate_text.Text = dtpEM_ExDate.Text;
            TextObject AmrAmount_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AmrAmount"];
            AmrAmount_text.Text = txtEM_AmrAmount.Text;
            TextObject AmrORNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AmrORNo"];
            AmrORNo_text.Text = txtEM_AmrORNo.Text;
            TextObject AmrDate_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AmrDate"];
            AmrDate_text.Text = dtpEM_AmrDate.Text;
            TextObject TranAmount_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["TranAmount"];
            TranAmount_text.Text = txtEM_TranAmount.Text;
            TextObject TranORNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["TranORNo"];
            TranORNo_text.Text = txtEM_TranORNo.Text;
            TextObject TranDate_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["TranDate"];
            TranDate_text.Text = dtpEM_TranDate.Text;
            crp.SetDataSource(ds);
            cmp.CRViewerMonitor.ReportSource = crp;
            cmp.CRViewerMonitor.Refresh();
            cmp.Show();



        }
    }
}
