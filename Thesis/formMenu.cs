using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            formOCR ocr = new formOCR();
            ocr.Show();
            this.Hide();
                
        }
    }
}
