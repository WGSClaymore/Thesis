using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;
using System.Data.SqlClient;

namespace Thesis
{
    public partial class formOCR : Form
    {
        public formOCR()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anrik\OneDrive\Documents\Cenrodb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\CENRODb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string Myquery = "select * from OCR1";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OCR.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            { txtFileLocation.Text = openFileDialog1.FileName; }
            else
            { txtFileLocation.Text = "You didn't select the file!"; }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.English;
            Ocr.Configuration.TesseractVersion = TesseractVersion.Tesseract5;
            using (var Input = new OcrInput())
            {
                var ContentArea = new System.Drawing.Rectangle()
                { X = 215, Y = 1700, Height = 300, Width = 1335 };  //<-- the area you want in px              

                Input.AddPdfPage(txtFileLocation.Text, 0, "null", ContentArea);



                var Result = Ocr.Read(Input);


                txtTitle.Text = Result.Text;
                Result.SaveAsTextFile("C:\\ocrtext.txt");
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into OCR1 values('" + txtTitle.Text + "', '"+DtpOCR.Text+"','"+tbOrdinance.Text+"') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Document Successfully Stored");
            Con.Close();
            populate();
            txtTitle.Clear();
        }

        private void formOCR_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void OCR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
