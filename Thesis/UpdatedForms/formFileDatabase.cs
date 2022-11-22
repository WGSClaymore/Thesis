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
    public partial class formFileDatabase : Form
    {
        public formFileDatabase()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CenroDB;Integrated Security=True");

        void populate()
        {
            Con.Open();
            string Myquery = "select * from ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvFileDatabase.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
