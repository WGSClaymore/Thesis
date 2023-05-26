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
    public partial class formExhumationMonitoring : Form
    {
        SqlConnection Con;
        public formExhumationMonitoring()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
      
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT Id AS 'ID', Date_Process AS 'Date Process', Date_ExTranDate AS 'Exhumanition Transaction Date', Name_of_Remains AS 'Name of Remains', " +
                "Type, DOD AS 'Date of Death', Contact_Person AS 'Contact Person', Contact_No AS 'Contact Number', Address, Relation," +
                "Em_From AS 'Exhumination Monitoring From', Em_To AS 'Exhumination Monitoring To', LotNo AS 'Lot Number', NicheNo AS 'Niche Number', LvlNo AS 'Level Number'," +
                "CWorker AS 'Contact Worker', CWorkerNo AS 'Contact Worker Number', Ex_Amount AS 'Exhumination Amount', Ex_ORNo AS 'Exhumination OR Number',EX_Date AS 'Exhumination Date', Amr_Amount AS 'Amoritization Amount'," +
                "Amr_ORNo AS 'Amoritization OR Number', Amr_Date AS 'Amoritization Date', Tran_Amount AS 'Transaction Amount', Tran_ORNo AS 'Transaction OR Number', Tran_Date AS 'Transaction Date' FROM ExhumanationMonitoring_Tbl ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DgvEM.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DgvEM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvEM.Rows.Count)
            {
                DataGridViewRow row = DgvEM.Rows[e.RowIndex];

                dtpEM_DateProcess.Text = Convert.ToString(row.Cells["Date Process"].Value);
                txtEMAddress.Text = Convert.ToString(row.Cells["Address"].Value);
                dtpEM_ExTranDate.Text = Convert.ToString(row.Cells["Exhumanition Transaction Date"].Value);
                txtEMRelation.Text = Convert.ToString(row.Cells["Relation"].Value);
                txtEM_ExORNo.Text = Convert.ToString(row.Cells["Exhumination OR Number"].Value);
                txtNameRemains.Text = Convert.ToString(row.Cells["Name of Remains"].Value);
                dtpDOD.Text = Convert.ToString(row.Cells["Date of Death"].Value);
                txtEMCPerson.Text = Convert.ToString(row.Cells["Contact Person"].Value);
                txtEMCPNo.Text = Convert.ToString(row.Cells["Contact Number"].Value);
                txtEMFrom.Text = Convert.ToString(row.Cells["Exhumination Monitoring From"].Value);
                txtEMTo.Text = Convert.ToString(row.Cells["Exhumination Monitoring To"].Value);
                txtEMLotNo.Text = Convert.ToString(row.Cells["Lot Number"].Value);
                txtEMNicheNo.Text = Convert.ToString(row.Cells["Niche Number"].Value);
                txtEMLvlNo.Text = Convert.ToString(row.Cells["Level Number"].Value);
                txtEMWorker.Text = Convert.ToString(row.Cells["Contact Worker"].Value);
                txtEMWorker_ContactNo.Text = Convert.ToString(row.Cells["Contact Worker Number"].Value);
                txtEM_ExAmount.Text = Convert.ToString(row.Cells["Exhumination Amount"].Value);
                txtEM_AmrAmount.Text = Convert.ToString(row.Cells["Amoritization Amount"].Value);
                txtEM_AmrORNo.Text = Convert.ToString(row.Cells["Amoritization OR Number"].Value);
                dtpEM_AmrDate.Text = Convert.ToString(row.Cells["Amoritization Date"].Value);
                txtEM_TranAmount.Text = Convert.ToString(row.Cells["Transaction Amount"].Value);
                txtEM_TranORNo.Text = Convert.ToString(row.Cells["Transaction OR Number"].Value);
                dtpEM_TranDate.Text = Convert.ToString(row.Cells["Transaction Date"].Value);
                CbEMType.Text = Convert.ToString(row.Cells["Type"].Value);
                lblExMonID.Text = Convert.ToString(row.Cells["ID"].Value);


            }

        }

        private void formExhumationMonitoring_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void ClearText()
        {
            CbEMType.Text = " ";           
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
            txtEM_AmrAmount.Clear();
            txtEM_AmrORNo.Clear();           
            txtEM_TranAmount.Clear();
            txtEM_TranORNo.Clear();
            
        }
        private void btnAddEM_Click(object sender, EventArgs e)
        {
            try
            {
                
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ExhumanationMonitoring_Tbl VALUES ( @Date_Process, @Date_ExTranDate, @Name_of_Remains, @DOD, @Contact_Person, @Contact_No, " +
                    "@Address, @Relation, @Em_From, @Em_To, @LotNo, @NicheNo, @LvlNo, @CWorker, @CWorkerNo, @Ex_Amount, @Ex_ORNo, @Ex_Date, @Amr_Amount, @Amr_ORNo," +
                    "@Amr_Date, @Tran_Amount, @Tran_ORNo, @Tran_Date, @Type)", Con);


                cmd.Parameters.AddWithValue("@Date_Process", dtpEM_DateProcess.Text);
                cmd.Parameters.AddWithValue("@Date_ExTranDate", dtpEM_ExTranDate.Text);
                cmd.Parameters.AddWithValue("@Name_of_Remains", txtNameRemains.Text);
                cmd.Parameters.AddWithValue("@DOD", dtpDOD.Text);
                cmd.Parameters.AddWithValue("@Contact_Person", txtEMCPerson.Text);
                cmd.Parameters.AddWithValue("@Contact_No", txtEMCPNo.Text);
                cmd.Parameters.AddWithValue("@Address", txtEMAddress.Text);
                cmd.Parameters.AddWithValue("@Relation", txtEMRelation.Text);
                cmd.Parameters.AddWithValue("@Em_From", txtEMFrom.Text);
                cmd.Parameters.AddWithValue("@Em_To", txtEMTo.Text);
                cmd.Parameters.AddWithValue("@LotNo", txtEMLotNo.Text);
                cmd.Parameters.AddWithValue("@NicheNo", txtEMNicheNo.Text);
                cmd.Parameters.AddWithValue("@LvlNo", txtEMLvlNo.Text);
                cmd.Parameters.AddWithValue("@CWorker", txtEMWorker.Text);
                cmd.Parameters.AddWithValue("@CWorkerNo", txtEMWorker_ContactNo.Text);
                cmd.Parameters.AddWithValue("@Ex_Amount", txtEM_ExAmount.Text);
                cmd.Parameters.AddWithValue("@Ex_ORNo", txtEM_ExORNo.Text);
                cmd.Parameters.AddWithValue("@Ex_Date", dtpEM_ExTranDate.Value);
                cmd.Parameters.AddWithValue("@Amr_Amount", txtEM_AmrAmount.Text);
                cmd.Parameters.AddWithValue("@Amr_ORNo", txtEM_AmrORNo.Text);
                cmd.Parameters.AddWithValue("@Amr_Date", dtpEM_AmrDate.Text);
                cmd.Parameters.AddWithValue("@Tran_Amount", txtEM_TranAmount.Text);
                cmd.Parameters.AddWithValue("@Tran_ORNo", txtEM_TranORNo.Text);
                cmd.Parameters.AddWithValue("@Tran_Date", dtpEM_TranDate.Text);
                cmd.Parameters.AddWithValue("@Type", CbEMType.Text);                  
                cmd.ExecuteNonQuery();
                MessageBox.Show("New exhumation monitoring permit has been successfully added", "Success!");
                Con.Close();
                populate();
                ClearText();

            }
            catch
            {
                Con.Close();
            }
           
        }

        private void btnEditEM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();

                    string query = "UPDATE ExhumanationMonitoring_Tbl SET Date_Process = @Date_Process, Date_ExTranDate = @Date_ExTranDate, Name_of_Remains = @Name_of_Remains, " +
                                   "DOD = @DOD, Contact_Person = @Contact_Person, Contact_No = @Contact_No, Address = @Address, Relation = @Relation, Em_From = @Em_From, " +
                                   "Em_To = @Em_To, LotNo = @LotNo, NicheNo = @NicheNo, LvlNo = @LvlNo, CWorker = @CWorker, CWorkerNo = @CWorkerNo, Ex_Amount = @Ex_Amount, " +
                                   "Ex_ORNo = @Ex_ORNo, Ex_Date = @Ex_Date, Amr_Amount = @Amr_Amount, Amr_ORNo = @Amr_ORNo, Amr_Date = @Amr_Date, Tran_Amount = @Tran_Amount, " +
                                   "Tran_ORNo = @Tran_ORNo, Tran_Date = @Tran_Date, Type = @Type WHERE Id = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@Date_Process", dtpEM_DateProcess.Text);
                        cmd.Parameters.AddWithValue("@Date_ExTranDate", dtpEM_ExTranDate.Text);
                        cmd.Parameters.AddWithValue("@Name_of_Remains", txtNameRemains.Text);
                        cmd.Parameters.AddWithValue("@DOD", dtpDOD.Text);
                        cmd.Parameters.AddWithValue("@Contact_Person", txtEMCPerson.Text);
                        cmd.Parameters.AddWithValue("@Contact_No", txtEMCPNo.Text);
                        cmd.Parameters.AddWithValue("@Address", txtEMAddress.Text);
                        cmd.Parameters.AddWithValue("@Relation", txtEMRelation.Text);
                        cmd.Parameters.AddWithValue("@Em_From", txtEMFrom.Text);
                        cmd.Parameters.AddWithValue("@Em_To", txtEMTo.Text);
                        cmd.Parameters.AddWithValue("@LotNo", txtEMLotNo.Text);
                        cmd.Parameters.AddWithValue("@NicheNo", txtEMNicheNo.Text);
                        cmd.Parameters.AddWithValue("@LvlNo", txtEMLvlNo.Text);
                        cmd.Parameters.AddWithValue("@CWorker", txtEMWorker.Text);
                        cmd.Parameters.AddWithValue("@CWorkerNo", txtEMWorker_ContactNo.Text);
                        cmd.Parameters.AddWithValue("@Ex_Amount", txtEM_ExAmount.Text);
                        cmd.Parameters.AddWithValue("@Ex_ORNo", txtEM_ExORNo.Text);
                        cmd.Parameters.AddWithValue("@Ex_Date", dtpEM_ExTranDate.Text);
                        cmd.Parameters.AddWithValue("@Amr_Amount", txtEM_AmrAmount.Text);
                        cmd.Parameters.AddWithValue("@Amr_ORNo", txtEM_AmrORNo.Text);
                        cmd.Parameters.AddWithValue("@Amr_Date", dtpEM_AmrDate.Text);
                        cmd.Parameters.AddWithValue("@Tran_Amount", txtEM_TranAmount.Text);
                        cmd.Parameters.AddWithValue("@Tran_ORNo", txtEM_TranORNo.Text);
                        cmd.Parameters.AddWithValue("@Tran_Date", dtpEM_TranDate.Text);
                        cmd.Parameters.AddWithValue("@Type", CbEMType.Text);
                        cmd.Parameters.AddWithValue("@ID", lblExMonID.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Exhumation monitoring permit has been successfully edited", "Success!");
                    Con.Close();
                    populate();
                    ClearText();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
            }
            
        }

        private void btnDeleteEM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    string Myquery = "DELETE FROM ExhumanationMonitoring_Tbl WHERE Id='" + lblExMonID.Text + "'";
                    SqlCommand cmd = new SqlCommand(Myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exhumation monitoring permit successfully deleted", "Success!");
                    Con.Close();
                    populate();
                    ClearText();
                    clearselect();
                }
                catch
                {
                    MessageBox.Show("An Error Occured", "Error");
                    Con.Close();
                }
            }
               
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
        private void clearselect()
        {
            DgvEM.ClearSelection();
            foreach (DataGridViewColumn column in DgvEM.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void CbEMType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void DgvEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
