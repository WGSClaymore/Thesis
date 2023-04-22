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
    public partial class formExhumationTransfer : Form
    {
        public formExhumationTransfer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=Final;Integrated Security=True");
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from ExhumanationTransfer_Tbl ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvExTran.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void formExhumationTransfer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" insert into ExhumanationTransfer_Tbl values ('"+dtpET_DateProcess.Text+"','"+dtpET_ExTranDate.Text+"'," +
            "'"+txtETRemains.Text+"','"+dtpETDOD.Text+"','"+txtETCPerson.Text+"','"+txtETCPersonNo.Text+"','"+txtETAddress.Text+"','"+txtETRelation.Text+"'," +
            "'"+txtETFrom.Text+"','"+txtETTo.Text+"','"+txtETLotNo.Text+"','"+txtETNicheNo.Text+"','"+txtETLvlNo.Text+"','"+txtETCWorker.Text+"'," +
            "'"+txtETCWorkerNo.Text+"','"+txtETExAmount.Text+"','"+txtETExORNo.Text+"','"+dtpETExDate.Text+"','"+txtETAmrAmount.Text+"','"+txtETAmrORNo.Text+"'," +
            "'"+dtpETAmrDate.Text+"','"+txtETTranAmount.Text+"','"+txtETTranORNo.Text+"','"+dtpETTranDate.Text+"','"+CbETType.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New exhumation transfer permit has been successfully recorded");
            Con.Close();
            populate();
            CbETType.Text = " ";
            txtETRemains.Clear();
            txtETCPerson.Clear();
            txtETCPersonNo.Clear();
            txtETAddress.Clear();
            txtETRelation.Clear();
            txtETFrom.Clear();
            txtETTo.Clear();
            txtETLotNo.Clear();
            txtETNicheNo.Clear();
            txtETLvlNo.Clear();
            txtETCWorker.Clear();
            txtETCWorkerNo.Clear();
            txtETExAmount.Clear();
            txtETExORNo.Clear();
            txtETAmrAmount.Clear();
            txtETAmrORNo.Clear();
            txtETTranAmount.Text = "";
            txtETTranORNo.Clear();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ExhumanationTransfer_Tbl Set Date_Process='" + dtpET_DateProcess.Text + "', " +
            "Date_ExTranDate='" + dtpET_ExTranDate.Text + "', Name_of_Remains='" + txtETRemains.Text + "', DOD='" + dtpETDOD.Text + "', " +
            "Contact_Person='" + txtETCPerson.Text + "', Contact_No='" + txtETCPersonNo.Text + "', Address='" + txtETAddress.Text + "', " +
            "Relation='" + txtETRelation.Text + "', Em_From='" + txtETFrom.Text + "', Em_To='" + txtETTo.Text + "', LotNo='" + txtETLotNo.Text + "', " +
            "NicheNo='" + txtETNicheNo.Text + "', LvlNo='" + txtETLvlNo.Text + "', CWorker='" + txtETCWorker.Text + "', CWorkerNo='" + txtETCWorkerNo.Text + "', " +
            "Ex_Amount='" + txtETExAmount.Text + "', Ex_ORNo='" + txtETExORNo.Text + "', Ex_Date='" + dtpETExDate.Text + "', Amr_Amount='" + txtETAmrAmount + "', " +
            "Amr_ORNo='" + txtETAmrORNo.Text + "', Amr_Date='" + dtpETAmrDate.Text + "', Tran_Amount='" + txtETTranAmount.Text + "', " +
            "Tran_ORNo='" + txtETTranORNo.Text + "', Tran_Date='" + dtpETTranDate.Text + "', Type='" + CbETType.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Exhumation transfer permit has been successfully edited");
            Con.Close();
            populate();
            CbETType.Text = " ";
            txtETRemains.Clear();
            txtETCPerson.Clear();
            txtETCPersonNo.Clear();
            txtETAddress.Clear();
            txtETRelation.Clear();
            txtETFrom.Clear();
            txtETTo.Clear();
            txtETLotNo.Clear();
            txtETNicheNo.Clear();
            txtETLvlNo.Clear();
            txtETCWorker.Clear();
            txtETCWorkerNo.Clear();
            txtETExAmount.Clear();
            txtETExORNo.Clear();
            txtETAmrAmount.Clear();
            txtETAmrORNo.Clear();
            txtETTranAmount.Clear();
            txtETTranORNo.Clear();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ExhumanationTransfer_Tbl where NameRemains='" + txtETRemains.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Exhumation transfer permit successfully deleted");
            Con.Close();
            populate();
            CbETType.Text = " ";
            txtETRemains.Text = " ";
            txtETCPerson.Text = " ";
            txtETCPersonNo.Clear();
            txtETAddress.Clear();
            txtETRelation.Clear();
            txtETFrom.Clear();
            txtETTo.Clear();
            txtETLotNo.Clear();
            txtETNicheNo.Clear();
            txtETLvlNo.Clear();
            txtETCWorker.Clear();
            txtETCWorkerNo.Clear();
            txtETExAmount.Clear();
            txtETExORNo.Clear();
            txtETAmrAmount.Clear();
            txtETAmrORNo.Clear();
            txtETTranAmount.Text = "";
            txtETTranORNo.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpET_DateProcess.Text = dgvExTran.SelectedRows[0].Cells[1].Value.ToString();
            dtpET_ExTranDate.Text = dgvExTran.SelectedRows[0].Cells[2].Value.ToString();
            txtETRemains.Text = dgvExTran.SelectedRows[0].Cells[3].Value.ToString();
            dtpETDOD.Text = dgvExTran.SelectedRows[0].Cells[4].Value.ToString();
            txtETCPerson.Text = dgvExTran.SelectedRows[0].Cells[5].Value.ToString();
            txtETCPersonNo.Text = dgvExTran.SelectedRows[0].Cells[6].Value.ToString();
            txtETAddress.Text = dgvExTran.SelectedRows[0].Cells[7].Value.ToString();
            txtETRelation.Text = dgvExTran.SelectedRows[0].Cells[8].Value.ToString();
            txtETFrom.Text = dgvExTran.SelectedRows[0].Cells[9].Value.ToString();
            txtETTo.Text = dgvExTran.SelectedRows[0].Cells[10].Value.ToString();
            txtETLotNo.Text = dgvExTran.SelectedRows[0].Cells[11].Value.ToString();
            txtETNicheNo.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            txtETLvlNo.Text = dgvExTran.SelectedRows[0].Cells[13].Value.ToString();
            txtETCWorker.Text = dgvExTran.SelectedRows[0].Cells[14].Value.ToString();
            txtETCWorkerNo.Text = dgvExTran.SelectedRows[0].Cells[15].Value.ToString();
            txtETExAmount.Text = dgvExTran.SelectedRows[0].Cells[16].Value.ToString();
            txtETExORNo.Text = dgvExTran.SelectedRows[0].Cells[17].Value.ToString();
            dtpETExDate.Text = dgvExTran.SelectedRows[0].Cells[18].Value.ToString();
            txtETAmrAmount.Text = dgvExTran.SelectedRows[0].Cells[19].Value.ToString();
            txtETAmrORNo.Text = dgvExTran.SelectedRows[0].Cells[20].Value.ToString();
            dtpETAmrDate.Text = dgvExTran.SelectedRows[0].Cells[21].Value.ToString();
            txtETTranAmount.Text = dgvExTran.SelectedRows[0].Cells[22].Value.ToString();
            txtETTranORNo.Text = dgvExTran.SelectedRows[0].Cells[23].Value.ToString();
            dtpETTranDate.Text = dgvExTran.SelectedRows[0].Cells[24].Value.ToString();
            CbETType.Text = dgvExTran.SelectedRows[0].Cells[25].Value.ToString();
        }

        private void btnPrintET_Click(object sender, EventArgs e)
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

            CrystalViewerTransfer cmp = new CrystalViewerTransfer();
            crNewTransfer crp = new crNewTransfer();

            foreach (DataGridViewRow dgv in dgvExTran.Rows)
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
            ds.WriteXmlSchema("ExhumnationTransfer.xml");
            TextObject Type_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Type"];
            Type_text.Text = CbETType.Text;
            TextObject DateProcess_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["DateProcess"];
            DateProcess_text.Text = dtpET_DateProcess.Text;
            TextObject DateExTran_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["DateExTran"];
            DateExTran_text.Text = dtpET_ExTranDate.Text;
            TextObject NameRemains_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["NameRemains"];
            NameRemains_text.Text = txtETRemains.Text;
            TextObject DOD_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["DOD"];
            DOD_text.Text = dtpETDOD.Text;
            TextObject CPerson_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CPerson"];
            CPerson_text.Text = txtETCPerson.Text;
            TextObject CPersonNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CPersonNo"];
            CPersonNo_text.Text = txtETCPersonNo.Text;
            TextObject Address_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Address"];
            Address_text.Text = txtETAddress.Text;
            TextObject Relation_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["Relation"];
            Relation_text.Text = txtETRelation.Text;
            TextObject From_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["From"];
            From_text.Text = txtETFrom.Text;
            TextObject To_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["To"];
            To_text.Text = txtETTo.Text;
            TextObject LotNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["LotNo"];
            LotNo_text.Text = txtETLotNo.Text;
            TextObject NicheNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["NicheNo"];
            NicheNo_text.Text = txtETNicheNo.Text;
            TextObject LvlNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["LvlNo"];
            LvlNo_text.Text = txtETLvlNo.Text;
            TextObject CWorker_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CWorker"];
            CWorker_text.Text = txtETCWorker.Text;
            TextObject CWorkerNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["CWorkerNo"];
            CWorkerNo_text.Text = txtETCWorkerNo.Text;
            TextObject ExAmount_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ExAmount"];
            ExAmount_text.Text = txtETExAmount.Text;
            TextObject ExORNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ExORNo"];
            ExORNo_text.Text = txtETExORNo.Text;
            TextObject ExDate_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["ExDate"];
            ExDate_text.Text = dtpETExDate.Text;
            TextObject AmrAmount_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AmrAmount"];
            AmrAmount_text.Text = txtETAmrAmount.Text;
            TextObject AmrORNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AmrORNo"];
            AmrORNo_text.Text = txtETAmrORNo.Text;
            TextObject AmrDate_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["AmrDate"];
            AmrDate_text.Text = dtpETAmrDate.Text;
            TextObject TranAmount_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["TranAmount"];
            TranAmount_text.Text = txtETTranAmount.Text;
            TextObject TranORNo_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["TranORNo"];
            TranORNo_text.Text = txtETTranORNo.Text;
            TextObject TranDate_text = (TextObject)crp.ReportDefinition.Sections["Section3"].ReportObjects["TranDate"];
            TranDate_text.Text = dtpETTranDate.Text;
            crp.SetDataSource(ds);
            cmp.CRViewerTransfer.ReportSource = crp;
            cmp.CRViewerTransfer.Refresh();
            cmp.Show();
        }
    }
}
