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

namespace Thesis.UpdatedForms
{
    public partial class formFileUpload : Form
    {
        public formFileUpload()
        {
            InitializeComponent();
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
            { txtFileLocation.Text = openFileDialog1.FileName;
                axAcroPDF1.src = txtFileLocation.Text;
            
            }
            else
            { txtFileLocation.Text = "You didn't select any file!"; }
            
        }

        private void btnConfirmOCR_Click(object sender, EventArgs e)
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
}
