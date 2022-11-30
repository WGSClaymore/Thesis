using IronOcr;
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
using System.IO;
namespace Thesis.UpdatedForms
{
    public partial class formFileUpload : Form
    {
        public formFileUpload()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-OM3OLFRT\SQLEXPRESS01;Initial Catalog=CENRO_DB_Final;Integrated Security=True");
        void populate()
        {
            Con.Open();
            string Myquery = "select File_ID,FileType,FileNo,Title,Date,Extension,FileName from Archive_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvDocuments.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                txtFileLocation.Text = openFileDialog1.FileName;
                axAcroPDF1.src = txtFileLocation.Text;

            }
            else
            { txtFileLocation.Text = "You didn't select any file!"; }

        }

        private void btnConfirmOCR_Click(object sender, EventArgs e)
        {
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


                    txtFileTitle.Text = Result.Text;
                    //   Result.SaveAsTextFile("D:\\ocrtext.txt");
                }
            }
        }
//*********************************************************************************************************************************************************************************************
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFileLocation.Text = dlg.FileName;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFile(txtFileLocation.Text);
            MessageBox.Show("Saved");
        }
        private void SaveFile(string filepath)
        {
            using (Stream stream = File.OpenRead(filepath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filepath);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO Archive_Tbl(FileType,FileNo,Title,Date,Data,Extension,FileName)VALUES(@filetype,@fileno,@title,@date,@data,@extn,@name)";
                using (SqlConnection cn = GetConnection())
                {
                    cn.Open();
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@filetype", SqlDbType.Text).Value = txtFileType.Text;
                    cmd.Parameters.AddWithValue("@fileno", SqlDbType.Text).Value = txtFileNo.Text;
                    cmd.Parameters.AddWithValue("@title", SqlDbType.Text).Value = txtFileTitle.Text;
                    cmd.Parameters.AddWithValue("@date", SqlDbType.Text).Value = dtpFileUpload.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                populate();
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-OM3OLFRT\SQLEXPRESS01;Initial Catalog=CENRO_DB_Final;Integrated Security=True");
        }

        private void formFileUpload_Load(object sender, EventArgs e)
        {
            LoadData();
            populate();
        }
        private void LoadData()
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT File_ID,FileName,Extension FROM Archive_Tbl";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvDocuments.DataSource = dt;
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDocuments.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM Archive_Tbl WHERE File_ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

