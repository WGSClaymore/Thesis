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
       
        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from TaskManagement_Tbl";
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
            SqlCommand cmd = new SqlCommand("insert into TaskManagement_Tbl values('" + Act.Text + "', '" + SubAct.Text + "', '" + Supervisor.Text + "', '" + Collab.Text + "', " +
            "'" + Resources.Text + "','"+Descript.Text+"', '" + DateStart.Text + "', '" + DateEnd.Text + "', '" + Outcome.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task information successfully added");
            Con.Close();
            populate();
            Act.Clear();
            SubAct.Clear();
            Supervisor.Clear();
            Collab.Clear();
            Resources.Clear();
            Descript.Clear();
            DateStart.Text = "";
            DateEnd.Text = "";
            Outcome.Clear();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update TaskManagement_Tbl set Task_Name='" + Act.Text + "', Sub_Activity='" + SubAct.Text + "', " +
            "Responsible_Person='" + Supervisor.Text + "', Collaborations='" + Collab.Text + "', Source_of_Resources='" + Resources.Text + "', " +
            "Description='"+Descript.Text+"',Date_Start='" + DateStart.Text + "', Date_End='" + DateEnd.Text + "', Expected_Outcome='" + Outcome.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task information successfully edited");
            Con.Close();
            populate();
            Act.Clear();
            SubAct.Clear();
            Supervisor.Clear();
            Collab.Clear();
            Resources.Clear();
            Descript.Clear();
            DateStart.Text = "";
            DateEnd.Text = "";
            Outcome.Clear();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from TaskManagement_Tbl where Task_Name='" + Act.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task information successfully deleted");
            Con.Close();
            populate();
            Act.Clear();
            SubAct.Clear();
            Supervisor.Clear();
            Collab.Clear();
            Resources.Clear();
            Descript.Clear();
            DateStart.Text = "";
            DateEnd.Text = "";
            Outcome.Clear();
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTask.Rows.Count)
            {
                Act.Text = dgvTask.SelectedRows[0].Cells[1].Value.ToString();
                SubAct.Text = dgvTask.SelectedRows[0].Cells[2].Value.ToString();
                Supervisor.Text = dgvTask.SelectedRows[0].Cells[3].Value.ToString();
                Collab.Text = dgvTask.SelectedRows[0].Cells[4].Value.ToString();
                Resources.Text = dgvTask.SelectedRows[0].Cells[5].Value.ToString();
                Descript.Text = dgvTask.SelectedRows[0].Cells[6].Value.ToString();
                DateStart.Text = dgvTask.SelectedRows[0].Cells[7].Value.ToString();
                DateEnd.Text = dgvTask.SelectedRows[0].Cells[8].Value.ToString();
                Outcome.Text = dgvTask.SelectedRows[0].Cells[9].Value.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
