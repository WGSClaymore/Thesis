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
    public partial class formExhumationTransfer : Form
    {
        public formExhumationTransfer()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=KOD\SQLEXPRESS01;Initial Catalog=CENRO_DB(OJT version);Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CENRO_DB(OJT version 2);Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from ExhumationNewTransfer_Tbl ";
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
            SqlCommand cmd = new SqlCommand(" insert into ExhumationNewTransfer_Tbl values ( '" + CbType.Text + "','" + Remains.Text + "'," +
            "'" + ConPerson.Text + "','" + ConNo.Text + "','" + Address.Text + "','" + RelDeceased.Text + "','" + From.Text + "','" + To.Text + "'," +
            "'" + LotNo.Text + "','" + NicheNo.Text + "','" + LevelNo.Text + "','" + ConWorker.Text + "','" + ConNoWorker.Text + "','" + ExAmount.Text + "'," +
            "'" + ExORNo.Text + "','" + ExDate.Text + "','" + AmAmount.Text + "','" + AmORNo.Text + "','" + AmDate.Text + "','" + TransAmount.Text + "'," +
            "'" + TransORNo.Text + "','" + TransDate.Text + "', '"+ CbType.Text +"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New exhumation transfer permit has been successfully recorded");
            Con.Close();
            populate();
            CbType.Text = " ";
            Remains.Text = " ";
            ConPerson.Text = " ";
            ConNo.Clear();
            Address.Clear();
            RelDeceased.Clear();
            From.Clear();
            To.Clear();
            LotNo.Clear();
            NicheNo.Clear();
            LevelNo.Clear();
            ConWorker.Clear();
            ConNoWorker.Clear();
            ExAmount.Clear();
            ExORNo.Clear();
            AmAmount.Clear();
            AmORNo.Clear();
            TransAmount.Text = "";
            TransORNo.Clear();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update ExhumationNewTransfer_Tbl Set NameRemains='" + Remains.Text + "', CPerson = '" + ConPerson.Text + "', " +
            "CPersonNo='" + ConNo.Text + "', ddress='" + Address.Text + "', Relation='" + RelDeceased.Text + "', CFrom='" + From.Text + "', CTo='" + To.Text + "'," +
            "LotNo='" + LotNo.Text + "', NicheNo='" + NicheNo.Text + "', LvlNo='" + LevelNo.Text + "', CWorker='" + ConWorker.Text + "'," +
            "CWorkerNo='" + ConNoWorker.Text + "', ExAmount='" + ExAmount.Text + "', ExORNo='" + ExORNo.Text + "', ExDate='" + ExDate.Text + "'," +
            "AmrAmount='" + AmAmount + "', AmrORNo='" + AmORNo.Text + "', AmrDate='" + AmDate.Text + "', TranAmount='" + TransAmount.Text + "'," +
            "TranORNo='" + TransORNo.Text + "', TranDate='" + TransDate.Text + "', Type='"+CbType.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Exhumation transfer permit has been successfully edited");
            Con.Close();
            populate();
            CbType.Text = " ";
            Remains.Text = " ";
            ConPerson.Text = " ";
            ConNo.Clear();
            Address.Clear();
            RelDeceased.Clear();
            From.Clear();
            To.Clear();
            LotNo.Clear();
            NicheNo.Clear();
            LevelNo.Clear();
            ConWorker.Clear();
            ConNoWorker.Clear();
            ExAmount.Clear();
            ExORNo.Clear();
            AmAmount.Clear();
            AmORNo.Clear();
            TransAmount.Text = "";
            TransORNo.Clear();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from ExhumationNewTransfer_Tbl where NameRemains='" + Remains.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Exhumation transfer permit successfully deleted");
            Con.Close();
            populate();
            CbType.Text = " ";
            Remains.Text = " ";
            ConPerson.Text = " ";
            ConNo.Clear();
            Address.Clear();
            RelDeceased.Clear();
            From.Clear();
            To.Clear();
            LotNo.Clear();
            NicheNo.Clear();
            LevelNo.Clear();
            ConWorker.Clear();
            ConNoWorker.Clear();
            ExAmount.Clear();
            ExORNo.Clear();
            AmAmount.Clear();
            AmORNo.Clear();
            TransAmount.Text = "";
            TransORNo.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Remains.Text = dgvExTran.SelectedRows[0].Cells[1].Value.ToString();
            ConPerson.Text = dgvExTran.SelectedRows[0].Cells[2].Value.ToString();
            ConNo.Text = dgvExTran.SelectedRows[0].Cells[3].Value.ToString();
            Address.Text = dgvExTran.SelectedRows[0].Cells[4].Value.ToString();
            RelDeceased.Text = dgvExTran.SelectedRows[0].Cells[5].Value.ToString();
            From.Text = dgvExTran.SelectedRows[0].Cells[6].Value.ToString();
            To.Text = dgvExTran.SelectedRows[0].Cells[7].Value.ToString();
            LotNo.Text = dgvExTran.SelectedRows[0].Cells[8].Value.ToString();
            NicheNo.Text = dgvExTran.SelectedRows[0].Cells[9].Value.ToString();
            LevelNo.Text = dgvExTran.SelectedRows[0].Cells[10].Value.ToString();
            ConWorker.Text = dgvExTran.SelectedRows[0].Cells[11].Value.ToString();
            ConNoWorker.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            ExAmount.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            ExORNo.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            ExDate.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            AmAmount.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            AmORNo.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            AmDate.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            TransAmount.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            TransORNo.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();
            TransDate.Text = dgvExTran.SelectedRows[0].Cells[12].Value.ToString();


        }


    }
}
