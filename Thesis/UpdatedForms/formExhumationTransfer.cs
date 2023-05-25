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
using System.Configuration;

namespace Thesis.UpdatedForms
{
    public partial class formExhumationTransfer : Form
    {
        SqlConnection Con;
        public formExhumationTransfer()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }

        void populate()
        {
            Con.Open();
            string Myquery = "SELECT Id AS 'ID', Date_Process AS 'Date Process', Date_ExTranDate AS 'Exhumanition Transaction Date', Name_of_Remains AS 'Name of Remains', " +
                "DOD AS 'Date of Death', Contact_Person AS 'Contact Person', Contact_No AS 'Contact Number', Address, Relation," +
                "Em_From AS 'Exhumination Monitoring From', Em_To AS 'Exhumination Monitoring To', LotNo AS 'Lot Number', NicheNo AS 'Niche Number', LvlNo AS 'Level Number'," +
                "CWorker AS 'Contact Worker', CWorkerNo AS 'Contact Worker Number', Ex_Amount AS 'Exhumination Amount', Ex_ORNo AS 'Exhumination OR Number',EX_Date AS 'Exhumination Date', Amr_Amount AS 'Amoritization Amount'," +
                "Amr_ORNo AS 'Amoritization OR Number', Amr_Date AS 'Amoritization Date', Tran_Amount AS 'Transaction Amount', Tran_ORNo AS 'Transaction OR Number', Tran_Date AS 'Transaction Date', Type FROM ExhumanationTransfer_Tbl ";
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
           private void btnAddExhumTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ExhumanationTransfer_Tbl VALUES ( @Date_Process, @Date_ExTranDate, @Name_of_Remains, @Type, @DOD, @Contact_Person, @Contact_No, " +
                    "@Address, @Relation, @Em_From, @Em_To, @LotNo, @NicheNo, @LvlNo, @CWorker, @CWorkerNo, @Ex_Amount, @Ex_ORNo, @Ex_Date, @Amr_Amount, @Amr_ORNo," +
                    "@Amr_Date, @Tran_Amount, @Tran_ORNo, @Tran_Date)", Con);

                cmd.Parameters.AddWithValue("@Date_Process", dtpET_DateProcess.Text);
                cmd.Parameters.AddWithValue("@Date_ExTranDate", dtpET_ExTranDate.Text);
                cmd.Parameters.AddWithValue("@Name_of_Remains", txtETRemains.Text);
                cmd.Parameters.AddWithValue("@DOD", dtpETDOD.Text);
                cmd.Parameters.AddWithValue("@Contact_Person", txtETCPerson.Text);
                cmd.Parameters.AddWithValue("@Contact_No", txtETCPersonNo.Text);
                cmd.Parameters.AddWithValue("@Address", txtETAddress.Text);
                cmd.Parameters.AddWithValue("@Relation", txtETRelation.Text);
                cmd.Parameters.AddWithValue("@Em_From", txtETFrom.Text);
                cmd.Parameters.AddWithValue("@Em_To", txtETTo.Text);
                cmd.Parameters.AddWithValue("@LotNo", txtETLotNo.Text);
                cmd.Parameters.AddWithValue("@NicheNo", txtETNicheNo.Text);
                cmd.Parameters.AddWithValue("@LvlNo", txtETLvlNo.Text);
                cmd.Parameters.AddWithValue("@CWorker", txtETCWorker.Text);
                cmd.Parameters.AddWithValue("@CWorkerNo", txtETCWorkerNo.Text);
                cmd.Parameters.AddWithValue("@Ex_Amount", txtETExAmount.Text);
                cmd.Parameters.AddWithValue("@Ex_ORNo", txtETExORNo.Text);
                cmd.Parameters.AddWithValue("@Ex_Date", dtpET_ExTranDate.Value);
                cmd.Parameters.AddWithValue("@Amr_Amount", txtETAmrAmount.Text);
                cmd.Parameters.AddWithValue("@Amr_ORNo", txtETAmrORNo.Text);
                cmd.Parameters.AddWithValue("@Amr_Date", dtpETAmrDate.Text);
                cmd.Parameters.AddWithValue("@Tran_Amount", txtETTranAmount.Text);
                cmd.Parameters.AddWithValue("@Tran_ORNo", txtETTranORNo.Text);
                cmd.Parameters.AddWithValue("@Tran_Date", dtpETTranDate.Text);
                cmd.Parameters.AddWithValue("@Type", CbETType.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New exhumation monitoring permit has been successfully added", "Success!");
                Con.Close();
                populate();
                

            }
            catch
            {
                Con.Close();
            }
        }
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();

                    string query = "UPDATE ExhumanationTransfer_Tbl SET Date_Process = @Date_Process, Date_ExTranDate = @Date_ExTranDate, Name_of_Remains = @Name_of_Remains, " +
                                   " Type = @Type, DOD = @DOD, Contact_Person = @Contact_Person, Contact_No = @Contact_No, Address = @Address, Relation = @Relation, Em_From = @Em_From, " +
                                   "Em_To = @Em_To, LotNo = @LotNo, NicheNo = @NicheNo, LvlNo = @LvlNo, CWorker = @CWorker, CWorkerNo = @CWorkerNo, Ex_Amount = @Ex_Amount, " +
                                   "Ex_ORNo = @Ex_ORNo, Ex_Date = @Ex_Date, Amr_Amount = @Amr_Amount, Amr_ORNo = @Amr_ORNo, Amr_Date = @Amr_Date, Tran_Amount = @Tran_Amount, " +
                                   "Tran_ORNo = @Tran_ORNo, Tran_Date = @Tran_Date WHERE Id = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@Date_Process", dtpET_DateProcess.Value);
                        cmd.Parameters.AddWithValue("@Date_ExTranDate", dtpETTranDate.Value);
                        cmd.Parameters.AddWithValue("@Name_of_Remains", txtETRemains.Text);
                        cmd.Parameters.AddWithValue("@DOD", dtpETDOD.Value);
                        cmd.Parameters.AddWithValue("@Contact_Person", txtETCPerson.Text);
                        cmd.Parameters.AddWithValue("@Contact_No", txtETCPersonNo.Text);
                        cmd.Parameters.AddWithValue("@Address", txtETAddress.Text);
                        cmd.Parameters.AddWithValue("@Relation", txtETRelation.Text);
                        cmd.Parameters.AddWithValue("@Em_From", txtETFrom.Text);
                        cmd.Parameters.AddWithValue("@Em_To", txtETTo.Text);
                        cmd.Parameters.AddWithValue("@LotNo", txtETLotNo.Text);
                        cmd.Parameters.AddWithValue("@NicheNo", txtETNicheNo.Text);
                        cmd.Parameters.AddWithValue("@LvlNo", txtETLvlNo.Text);
                        cmd.Parameters.AddWithValue("@CWorker", txtETCWorker.Text);
                        cmd.Parameters.AddWithValue("@CWorkerNo", txtETCWorkerNo.Text);
                        cmd.Parameters.AddWithValue("@Ex_Amount", txtETExAmount.Text);
                        cmd.Parameters.AddWithValue("@Ex_ORNo", txtETExORNo.Text);
                        cmd.Parameters.AddWithValue("@Ex_Date", dtpETExDate.Value);
                        cmd.Parameters.AddWithValue("@Amr_Amount", txtETAmrAmount.Text);
                        cmd.Parameters.AddWithValue("@Amr_ORNo", txtETAmrORNo.Text);
                        cmd.Parameters.AddWithValue("@Amr_Date", dtpETAmrDate.Value);
                        cmd.Parameters.AddWithValue("@Tran_Amount", txtETTranAmount.Text);
                        cmd.Parameters.AddWithValue("@Tran_ORNo", txtETTranORNo.Text);
                        cmd.Parameters.AddWithValue("@Tran_Date", dtpETTranDate.Value);
                        cmd.Parameters.AddWithValue("@Type", CbETType.Text);
                        cmd.Parameters.AddWithValue("@ID", lblExTranID.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Exhumation monitoring permit has been successfully edited", "Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    string Myquery = "DELETE FROM ExhumanationTransfer_Tbl WHERE Id='" + lblExTranID.Text + "'";
                    SqlCommand cmd = new SqlCommand(Myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exhumation transfer permit successfully deleted", "Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
                
            }
               
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

        private void dgvExTran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvExTran.Rows.Count)
            {
                DataGridViewRow row = dgvExTran.Rows[e.RowIndex];

                dtpET_DateProcess.Text = Convert.ToString(row.Cells["Date Process"].Value);
                txtETAddress.Text = Convert.ToString(row.Cells["Address"].Value);
                dtpET_ExTranDate.Text = Convert.ToString(row.Cells["Exhumanition Transaction Date"].Value);
                txtETRelation.Text = Convert.ToString(row.Cells["Relation"].Value);
                txtETExORNo.Text = Convert.ToString(row.Cells["Exhumination OR Number"].Value);
                txtETRemains.Text = Convert.ToString(row.Cells["Name of Remains"].Value);
                dtpETDOD.Text = Convert.ToString(row.Cells["Date of Death"].Value);
                txtETCPerson.Text = Convert.ToString(row.Cells["Contact Person"].Value);
                txtETCPersonNo.Text = Convert.ToString(row.Cells["Contact Number"].Value);
                txtETFrom.Text = Convert.ToString(row.Cells["Exhumination Monitoring From"].Value);
                txtETTo.Text = Convert.ToString(row.Cells["Exhumination Monitoring To"].Value);
                txtETLotNo.Text = Convert.ToString(row.Cells["Lot Number"].Value);
                txtETNicheNo.Text = Convert.ToString(row.Cells["Niche Number"].Value);
                txtETLvlNo.Text = Convert.ToString(row.Cells["Level Number"].Value);
                txtETCWorker.Text = Convert.ToString(row.Cells["Contact Worker"].Value);
                txtETCWorkerNo.Text = Convert.ToString(row.Cells["Contact Worker Number"].Value);
                txtETExAmount.Text = Convert.ToString(row.Cells["Exhumination Amount"].Value);
                txtETAmrAmount.Text = Convert.ToString(row.Cells["Amoritization Amount"].Value);
                txtETAmrORNo.Text = Convert.ToString(row.Cells["Amoritization OR Number"].Value);
                dtpETAmrDate.Text = Convert.ToString(row.Cells["Amoritization Date"].Value);
                txtETTranAmount.Text = Convert.ToString(row.Cells["Transaction Amount"].Value);
                txtETTranORNo.Text = Convert.ToString(row.Cells["Transaction OR Number"].Value);
                dtpETTranDate.Text = Convert.ToString(row.Cells["Transaction Date"].Value);
                CbETType.Text = Convert.ToString(row.Cells["Type"].Value);
                lblExTranID.Text = Convert.ToString(row.Cells["ID"].Value);


            }
        }
        private void cleartext()
        {
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
        private void clearselect()
        {
            dgvExTran.ClearSelection();
            foreach (DataGridViewColumn column in dgvExTran.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }

     
    }
}
