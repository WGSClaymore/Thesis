namespace Thesis
{
    partial class formMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.btnOCR = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnPermits = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnFIles = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelTItleBar = new System.Windows.Forms.Panel();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.panelDekstopPanel = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.panelTItleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOCR
            // 
            this.btnOCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOCR.FlatAppearance.BorderSize = 0;
            this.btnOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOCR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOCR.Image = ((System.Drawing.Image)(resources.GetObject("btnOCR.Image")));
            this.btnOCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOCR.Location = new System.Drawing.Point(0, 0);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(220, 66);
            this.btnOCR.TabIndex = 1;
            this.btnOCR.Text = "Upload a File";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 273);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(220, 69);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnPermits
            // 
            this.btnPermits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermits.FlatAppearance.BorderSize = 0;
            this.btnPermits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermits.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPermits.Image = ((System.Drawing.Image)(resources.GetObject("btnPermits.Image")));
            this.btnPermits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermits.Location = new System.Drawing.Point(0, 204);
            this.btnPermits.Name = "btnPermits";
            this.btnPermits.Size = new System.Drawing.Size(220, 69);
            this.btnPermits.TabIndex = 4;
            this.btnPermits.Text = "Permits";
            this.btnPermits.UseVisualStyleBackColor = true;
            this.btnPermits.Click += new System.EventHandler(this.btnPermits_Click);
            // 
            // btnComplaints
            // 
            this.btnComplaints.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComplaints.Image = ((System.Drawing.Image)(resources.GetObject("btnComplaints.Image")));
            this.btnComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaints.Location = new System.Drawing.Point(0, 66);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(220, 69);
            this.btnComplaints.TabIndex = 3;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnFIles
            // 
            this.btnFIles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFIles.FlatAppearance.BorderSize = 0;
            this.btnFIles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFIles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFIles.Image = ((System.Drawing.Image)(resources.GetObject("btnFIles.Image")));
            this.btnFIles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFIles.Location = new System.Drawing.Point(0, 135);
            this.btnFIles.Name = "btnFIles";
            this.btnFIles.Size = new System.Drawing.Size(220, 69);
            this.btnFIles.TabIndex = 2;
            this.btnFIles.Text = "Files";
            this.btnFIles.UseVisualStyleBackColor = true;
            this.btnFIles.Click += new System.EventHandler(this.btnFIles_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.Controls.Add(this.btnEmployee);
            this.panelmenu.Controls.Add(this.btnPermits);
            this.panelmenu.Controls.Add(this.btnFIles);
            this.panelmenu.Controls.Add(this.btnComplaints);
            this.panelmenu.Controls.Add(this.btnOCR);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 663);
            this.panelmenu.TabIndex = 7;
            // 
            // panelTItleBar
            // 
            this.panelTItleBar.BackColor = System.Drawing.Color.Teal;
            this.panelTItleBar.Controls.Add(this.lblTitleHome);
            this.panelTItleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTItleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTItleBar.Name = "panelTItleBar";
            this.panelTItleBar.Size = new System.Drawing.Size(1035, 100);
            this.panelTItleBar.TabIndex = 8;
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHome.ForeColor = System.Drawing.Color.White;
            this.lblTitleHome.Location = new System.Drawing.Point(379, 40);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(78, 26);
            this.lblTitleHome.TabIndex = 0;
            this.lblTitleHome.Text = "HOME";
            // 
            // panelDekstopPanel
            // 
            this.panelDekstopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstopPanel.Location = new System.Drawing.Point(220, 100);
            this.panelDekstopPanel.Name = "panelDekstopPanel";
            this.panelDekstopPanel.Size = new System.Drawing.Size(1035, 563);
            this.panelDekstopPanel.TabIndex = 9;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 663);
            this.Controls.Add(this.panelDekstopPanel);
            this.Controls.Add(this.panelTItleBar);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelmenu.ResumeLayout(false);
            this.panelTItleBar.ResumeLayout(false);
            this.panelTItleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnPermits;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnFIles;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelTItleBar;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.Panel panelDekstopPanel;
    }
}