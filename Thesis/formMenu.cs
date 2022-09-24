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
        private Form activeForm;

        //constructor
        public formMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

       private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTItleBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelmenu.Controls) 
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton (btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDekstopPanel.Controls.Add(childform);
            this.panelDekstopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitleHome.Text = childform.Text;
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formOCR(),sender);
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnFIles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnPermits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formPermit(), sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
