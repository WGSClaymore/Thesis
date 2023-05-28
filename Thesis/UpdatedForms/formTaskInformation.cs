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
using System.Configuration;

namespace Thesis.UpdatedForms
{
    public partial class formTaskInformation : Form
    {
        SqlConnection Con;
        public formTaskInformation()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }
       
       
        void populate()
        {
            Con.Open();
            string Myquery = "SELECT TaskM_ID AS 'ID', Task_Name AS 'Task Name', Sub_Activity AS 'Sub Activity'," +
                "Responsible_Person AS 'Responsible Person', Collaborations, Source_Of_Resources AS 'Source of Resources', Description, Date_Start AS 'Date Start', " +
                "Date_End AS 'Date End', Expected_Outcome AS 'Expected Outcome' FROM TaskManagement_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvTask.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void formTaskDatabase_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
          
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TaskManagement_Tbl VALUES (@Task_Name, @Sub_Activity, @Responsible_Person, @Collaborations, @Source_Of_Resources, @Description," +
                    "@Date_Start, @Date_End, @Expected_Outcome)", Con);

                cmd.Parameters.AddWithValue("@Task_Name", Act.Text);
                cmd.Parameters.AddWithValue("@Sub_Activity", SubAct.Text);
                cmd.Parameters.AddWithValue("@Responsible_Person", Supervisor.Text);
                cmd.Parameters.AddWithValue("@Collaborations", Collab.Text);
                cmd.Parameters.AddWithValue("@Source_Of_Resources", Resources.Text);
                cmd.Parameters.AddWithValue("@Description", Descript.Text);
                cmd.Parameters.AddWithValue("@Date_Start", DateStart.Text);
                cmd.Parameters.AddWithValue("@Date_End", DateEnd.Text);
                cmd.Parameters.AddWithValue("@Expected_Outcome", Outcome.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Task information successfully added", "Success!");
                Con.Close();
                populate();
                cleartext();
                clearselect();
           
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update TaskManagement_Tbl set Task_Name='" + Act.Text + "', Sub_Activity='" + SubAct.Text + "', " +
                    "Responsible_Person='" + Supervisor.Text + "', Collaborations='" + Collab.Text + "', Source_of_Resources='" + Resources.Text + "', " +
                    "Description='" + Descript.Text + "',Date_Start='" + DateStart.Text + "', Date_End='" + DateEnd.Text + "', Expected_Outcome='" + Outcome.Text + "' WHERE TaskM_ID = '" + lblTaskID.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task information successfully edited", "Success!");
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
                    string Myquery = "DELETE FROM TaskManagement_Tbl where TaskM_ID='" + lblTaskID.Text + "'";
                    SqlCommand cmd = new SqlCommand(Myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task information successfully deleted", "Success!");
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

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTask.Rows.Count)
            {
                DataGridViewRow row = dgvTask.Rows[e.RowIndex];
                lblTaskID.Text = Convert.ToString(row.Cells["ID"].Value);
                Act.Text = Convert.ToString(row.Cells["Task Name"].Value);
                SubAct.Text = Convert.ToString(row.Cells["Sub Activity"].Value);
                Supervisor.Text = Convert.ToString(row.Cells["Responsible Person"].Value);
                Collab.Text = Convert.ToString(row.Cells["Collaborations"].Value);
                Resources.Text = Convert.ToString(row.Cells["Source of Resources"].Value);
                Descript.Text = Convert.ToString(row.Cells["Description"].Value);
                DateStart.Text = Convert.ToString(row.Cells["Date Start"].Value);
                DateEnd.Text = Convert.ToString(row.Cells["Date End"].Value);
                Outcome.Text = Convert.ToString(row.Cells["Expected Outcome"].Value);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn clickedColumn = dgvTask.Columns[e.ColumnIndex];

               
                if (e.ColumnIndex > 0)
                {
                 
                    int minimumWidth = 300;

                    
                    switch (clickedColumn.Name)
                    {
                        case "ID":
                            
                            clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            clickedColumn.Width = minimumWidth; 
                            break;
                        default:
                            
                            clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            break;
                    }

                    if (clickedColumn.AutoSizeMode != DataGridViewAutoSizeColumnMode.None)
                    {
                       
                        DataGridViewAutoSizeColumnMode originalAutoSizeMode = clickedColumn.AutoSizeMode;

                        
                        clickedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        
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
        private void cleartext()
        {
            Act.Clear();
            SubAct.Clear();
            Supervisor.Clear();
            Collab.Clear();
            Resources.Clear();
            Descript.Clear();
            Outcome.Clear();
            lblTaskID.Text = "";
        }
        private void clearselect()
        {
            dgvTask.ClearSelection();
            foreach (DataGridViewColumn column in dgvTask.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formTaskInformation_Click(object sender, EventArgs e)
        {
            clearselect();
        }
    }
}
