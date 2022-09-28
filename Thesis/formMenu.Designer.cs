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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProjMng = new System.Windows.Forms.Button();
            this.panelTItleBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.panelDekstopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            this.panelTItleBar.SuspendLayout();
            this.panelDekstopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnOCR.Size = new System.Drawing.Size(239, 66);
            this.btnOCR.TabIndex = 1;
            this.btnOCR.Text = "Scan Document";
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
            this.btnEmployee.Location = new System.Drawing.Point(0, 66);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(239, 69);
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
            this.btnPermits.Location = new System.Drawing.Point(0, 342);
            this.btnPermits.Name = "btnPermits";
            this.btnPermits.Size = new System.Drawing.Size(239, 69);
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
            this.btnComplaints.Location = new System.Drawing.Point(0, 204);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(239, 69);
            this.btnComplaints.TabIndex = 3;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.Controls.Add(this.btnUsers);
            this.panelmenu.Controls.Add(this.btnPermits);
            this.panelmenu.Controls.Add(this.btnUpdate);
            this.panelmenu.Controls.Add(this.btnComplaints);
            this.panelmenu.Controls.Add(this.btnProjMng);
            this.panelmenu.Controls.Add(this.btnEmployee);
            this.panelmenu.Controls.Add(this.btnOCR);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(239, 655);
            this.panelmenu.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(0, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(239, 69);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Complaint";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 411);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(239, 69);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProjMng
            // 
            this.btnProjMng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjMng.FlatAppearance.BorderSize = 0;
            this.btnProjMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjMng.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProjMng.Image = ((System.Drawing.Image)(resources.GetObject("btnProjMng.Image")));
            this.btnProjMng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjMng.Location = new System.Drawing.Point(0, 135);
            this.btnProjMng.Name = "btnProjMng";
            this.btnProjMng.Size = new System.Drawing.Size(239, 69);
            this.btnProjMng.TabIndex = 6;
            this.btnProjMng.Text = "Project Management";
            this.btnProjMng.UseVisualStyleBackColor = true;
            this.btnProjMng.Click += new System.EventHandler(this.btnProjMng_Click);
            // 
            // panelTItleBar
            // 
            this.panelTItleBar.BackColor = System.Drawing.Color.Teal;
            this.panelTItleBar.Controls.Add(this.btnMin);
            this.panelTItleBar.Controls.Add(this.btnMax);
            this.panelTItleBar.Controls.Add(this.btnClose);
            this.panelTItleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTItleBar.Controls.Add(this.lblTitleHome);
            this.panelTItleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTItleBar.Location = new System.Drawing.Point(239, 0);
            this.panelTItleBar.Name = "panelTItleBar";
            this.panelTItleBar.Size = new System.Drawing.Size(986, 100);
            this.panelTItleBar.TabIndex = 8;
            this.panelTItleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTItleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(881, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(917, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(953, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 100);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.ButtonCloseChildForm_Click);
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHome.ForeColor = System.Drawing.Color.White;
            this.lblTitleHome.Location = new System.Drawing.Point(440, 29);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(78, 26);
            this.lblTitleHome.TabIndex = 0;
            this.lblTitleHome.Text = "HOME";
            this.lblTitleHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitleHome.Click += new System.EventHandler(this.lblTitleHome_Click);
            // 
            // panelDekstopPanel
            // 
            this.panelDekstopPanel.Controls.Add(this.pictureBox1);
            this.panelDekstopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstopPanel.Location = new System.Drawing.Point(239, 100);
            this.panelDekstopPanel.Name = "panelDekstopPanel";
            this.panelDekstopPanel.Size = new System.Drawing.Size(986, 555);
            this.panelDekstopPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 655);
            this.Controls.Add(this.panelDekstopPanel);
            this.Controls.Add(this.panelTItleBar);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelmenu.ResumeLayout(false);
            this.panelTItleBar.ResumeLayout(false);
            this.panelTItleBar.PerformLayout();
            this.panelDekstopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnPermits;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelTItleBar;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.Panel panelDekstopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProjMng;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnUpdate;
    }
}