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
        //fields
        private Button currentButton;
        private Random random;
        private int tempindex;

        //constructor
        public formMenu()
        {
            InitializeComponent();
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList)
        }
        private void btnOCR_Click(object sender, EventArgs e)
        {
            formOCR ocr = new formOCR();
            ocr.Show();
            this.Hide();
                
        }
    }
}
