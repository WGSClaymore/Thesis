﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thesis
{
    public partial class formEmployee : Form
    {
        public formEmployee()
        {
            InitializeComponent();
        }
      //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from EmpTbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Empdgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into EmpTbl values('" + EmpName.Text + "', '" + Pos.Text + "', '" + Item.Text + "', " +
            "'" + SG.Text + "', '" + Area.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Successfully Added");
            Con.Close();
            populate();
            EmpName.Clear();
            Pos.Clear();
            Item.Clear();
            SG.Clear();
            Area.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formMenu home = new formMenu();
            home.Show();
            this.Hide();
        }

        private void formEmployee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Empdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpName.Text = Empdgv.SelectedRows[0].Cells[1].Value.ToString();
            Pos.Text = Empdgv.SelectedRows[0].Cells[2].Value.ToString();
            Item.Text = Empdgv.SelectedRows[0].Cells[3].Value.ToString();
            SG.Text = Empdgv.SelectedRows[0].Cells[4].Value.ToString();
            Area.Text = Empdgv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "delete from EmpTbl where Item_No.='" + Item.Text + "'";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Information Successfully Deleted");
            Con.Close();
            populate();
            EmpName.Clear();
            Pos.Clear();
            Item.Clear();
            SG.Clear();
            Area.Clear();
        }

        private void formEmployee_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update EmpTbl set EmpName='" + EmpName.Text + "', Position='" + Pos.Text+"',Item_No.='"+Item.Text+"', SG_Step='"+SG.Text+"',Area_of_Assignment='"+Area.Text+"'",Con);
          //("update EmpTbl set  Position='" + Pos.Text + "',",Item_No.='"+Item.Text+"',SG_Step='" + SG.Text + "', Area_of_Assignment='" + Area.Text + "' where EmpName='" + EmpName.Text + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Information Successfully Updated");
            Con.Close();
            populate();
            EmpName.Clear();
            Pos.Clear();
            Item.Clear();
            SG.Clear();
            Area.Clear();
        }
    }
}
