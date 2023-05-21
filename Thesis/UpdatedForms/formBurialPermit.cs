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
             string Myquery = "SELECT Burial_ID AS 'ID', Name, Address, DOB AS 'Date of Birth', POB AS 'Place of Birth', DOD AS 'Date of Death', ATD AS 'Age of Time of Death', COD AS 'Cause of Death', " +
                 "Contact_Person AS 'Contact Person', Contact_Number AS 'Contact Number', Relation, DateFiling AS 'Date of Filing', DateInterment AS 'Date of Interment', " +
                 "Burial_Place AS 'Place of Burial', LotNo AS 'Lot Number', NicheNo AS 'Niche Number', LvlNo AS 'Level Number', Burial_Fee AS 'Burial Fee', Amount, OR_NO AS" +
                 " 'Order Receipt Number', TransDate AS 'Date of Transfer' FROM Burial_Tbl";           
           
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
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Burial_Tbl VALUES (@BurialName, @BurialAddress, @BurialDOB, @BurialPOB," +
                    " @BurialDateDeath, @BurialAgeDeath, @BurialCOD, @BurialCPerson, @BurialCPNo, " +
                    "@BurialRelation, @BurialDOF, @BurialDOI, @BurialPlace, @BurialLotNo, @BurialNicheNo, " +
                    "@BurialLvlNo, @BurialFee, @BurialAmount, @BurialORNo, @BurialTransDate)", Con);
                cmd.Parameters.AddWithValue("@BurialName", txtBurialName.Text);
                cmd.Parameters.AddWithValue("@BurialAddress", txtBurialAddress.Text);
                cmd.Parameters.AddWithValue("@BurialDOB", dtpBurialDOB.Value);
                cmd.Parameters.AddWithValue("@BurialPOB", txtBurialPOB.Text);
                cmd.Parameters.AddWithValue("@BurialDateDeath", dtpBurialDateDeath.Value);
                cmd.Parameters.AddWithValue("@BurialAgeDeath", txtBurialAgeDeath.Text);
                cmd.Parameters.AddWithValue("@BurialCOD", txtBurialCOD.Text);
                cmd.Parameters.AddWithValue("@BurialCPerson", txtBurialCPerson.Text);
                cmd.Parameters.AddWithValue("@BurialCPNo", txtBurialCPNo.Text);
                cmd.Parameters.AddWithValue("@BurialRelation", txtBurialRelation.Text);
                cmd.Parameters.AddWithValue("@BurialDOF", dtpBurialDOF.Value);
                cmd.Parameters.AddWithValue("@BurialDOI", dtpBurialDOI.Value);
                cmd.Parameters.AddWithValue("@BurialPlace", txtBurialPlace.Text);
                cmd.Parameters.AddWithValue("@BurialLotNo", txtBurialLotNo.Text);
                cmd.Parameters.AddWithValue("@BurialNicheNo", txtBurialNicheNo.Text);
                cmd.Parameters.AddWithValue("@BurialLvlNo", txtBurialLvlNo.Text);
                cmd.Parameters.AddWithValue("@BurialFee", txtBurialFee.Text);
                cmd.Parameters.AddWithValue("@BurialAmount", txtBurialAmount.Text);
                cmd.Parameters.AddWithValue("@BurialORNo", txtBurialORNo.Text);
                cmd.Parameters.AddWithValue("@BurialTransDate", dtpBurialTransDate.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New burial permit has been added", "Success");
                Con.Close();
                populate();
                cleartext();
                clearselect();
            }
            catch (SqlException ex)
            {

                {
                    if (ex.Number == 8152) // Error number for "String or binary data would be truncated"
                    {
                        MessageBox.Show("Exceeding character count of 50", "Error");
                    }

                    Con.Close();
                }
            }


        }

        private void btnEditBurial_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)              
            {
                try
                {
                    Con.Open();
                    string updateQuery = "UPDATE Burial_Tbl SET Name=@BurialName, Address=@BurialAddress, DOB=@BurialDOB, " +
                        "POB=@BurialPOB, ATD=@BurialAgeDeath, COD=@BurialCOD, Contact_Person=@BurialCPerson, " +
                        "Contact_Number=@BurialCPNo, Relation=@BurialRelation, DateFiling=@BurialDOF, " +
                        "DateInterment=@BurialDOI, Burial_Place=@BurialPlace, LotNo=@BurialLotNo, " +
                        "NicheNo=@BurialNicheNo, LvlNo=@BurialLvlNo, Burial_Fee=@BurialFee, Amount=@BurialAmount, " +
                        "OR_No=@BurialORNo, TransDate=@BurialTransDate WHERE Burial_ID=@BurialID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, Con);
                    updateCommand.Parameters.AddWithValue("@BurialName", txtBurialName.Text);
                    updateCommand.Parameters.AddWithValue("@BurialAddress", txtBurialAddress.Text);
                    updateCommand.Parameters.AddWithValue("@BurialDOB", dtpBurialDOB.Text);
                    updateCommand.Parameters.AddWithValue("@BurialPOB", txtBurialPOB.Text);
                    updateCommand.Parameters.AddWithValue("@BurialAgeDeath", txtBurialAgeDeath.Text);
                    updateCommand.Parameters.AddWithValue("@BurialCOD", txtBurialCOD.Text);
                    updateCommand.Parameters.AddWithValue("@BurialCPerson", txtBurialCPerson.Text);
                    updateCommand.Parameters.AddWithValue("@BurialCPNo", txtBurialCPNo.Text);
                    updateCommand.Parameters.AddWithValue("@BurialRelation", txtBurialRelation.Text);
                    updateCommand.Parameters.AddWithValue("@BurialDOF", dtpBurialDOF.Text);
                    updateCommand.Parameters.AddWithValue("@BurialDOI", dtpBurialDOI.Text);
                    updateCommand.Parameters.AddWithValue("@BurialPlace", txtBurialPlace.Text);
                    updateCommand.Parameters.AddWithValue("@BurialLotNo", txtBurialLotNo.Text);
                    updateCommand.Parameters.AddWithValue("@BurialNicheNo", txtBurialNicheNo.Text);
                    updateCommand.Parameters.AddWithValue("@BurialLvlNo", txtBurialLvlNo.Text);
                    updateCommand.Parameters.AddWithValue("@BurialFee", txtBurialFee.Text);
                    updateCommand.Parameters.AddWithValue("@BurialAmount", txtBurialAmount.Text);
                    updateCommand.Parameters.AddWithValue("@BurialORNo", txtBurialORNo.Text);
                    updateCommand.Parameters.AddWithValue("@BurialTransDate", dtpBurialTransDate.Text);
                    updateCommand.Parameters.AddWithValue("@BurialID",lblBurialID.Text);

                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Burial permit has been edited", "Success!");
                    Con.Close();
                    populate();
                    cleartext();
                    clearselect();
                }
                catch(SqlException ex)
                {

                    {
                        if (ex.Number == 8152) // Error number for "String or binary data would be truncated"
                        {
                            MessageBox.Show("Exceeding character count of 50", "Error");
                        }

                        Con.Close();
                    }
                }
                
            }
           
        }

    

        private void btnDeleteBurial_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Con.Open();
                string Myquery = "DELETE FROM Burial_Tbl WHERE Burial_ID= '" + lblBurialID.Text + "' ";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Burial permit successfully deleted", "Success!");
                Con.Close();
                populate();
                cleartext();
                clearselect();
            }
                
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
                lblBurialID.Text = Convert.ToString(row.Cells["ID"].Value);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn clickedColumn = dgvBurial.Columns[e.ColumnIndex];

                // Check if it's the header column (index 0)
                if (e.ColumnIndex > 0)
                {
                    // Set the minimum width for the column
                    int minimumWidth = 300; // Specify your desired minimum width

                    // Set the AutoSizeMode of the column to DisplayedCells
                    switch (clickedColumn.Name)
                    {
                        case "ID":
                            // Disable auto-sizing for ColumnName1 and ColumnName2
                            clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            clickedColumn.Width = minimumWidth; // Set the minimum width
                            break;
                        default:
                            // Enable auto-sizing for other columns
                            clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            break;
                    }

                    if (clickedColumn.AutoSizeMode != DataGridViewAutoSizeColumnMode.None)
                    {
                        // Store the original AutoSizeMode value
                        DataGridViewAutoSizeColumnMode originalAutoSizeMode = clickedColumn.AutoSizeMode;

                        // Disable auto-sizing for the clicked column
                        clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        // If clicked again, restore the original AutoSizeMode
                        if (clickedColumn.Tag == null)
                        {
                            clickedColumn.Tag = originalAutoSizeMode;
                        }
                        else
                        {
                            clickedColumn.AutoSizeMode = (DataGridViewAutoSizeColumnMode)clickedColumn.Tag;
                            clickedColumn.Tag = null;
                        }
                    }
                }
            }
        }
        void cleartext()
        {
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
        private void clearselect()
        {
            dgvBurial.ClearSelection();
            foreach (DataGridViewColumn column in dgvBurial.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void formBurialPermit_Click(object sender, EventArgs e)
        {
            clearselect();
        }
        public class DoubleBufferedDataGridView : DataGridView
        {
            public DoubleBufferedDataGridView()
            {
                DoubleBuffered = true;
            }
        }
    }
}
