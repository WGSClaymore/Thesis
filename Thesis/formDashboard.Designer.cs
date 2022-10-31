﻿namespace Thesis
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.subpanelOCRMenu = new System.Windows.Forms.Panel();
            this.btnFileDatabase = new System.Windows.Forms.Button();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnProjectManagement = new System.Windows.Forms.Button();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPermits = new System.Windows.Forms.Button();
            this.btnCommunityComplaints = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.subpanelProjManagement = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFileManagement = new System.Windows.Forms.Button();
            this.subpanelOCRMenu.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            this.subpanelProjManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(290, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1168, 703);
            this.panelChildForm.TabIndex = 6;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Thesis.Properties.Resources.icons8_home_page_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(290, 43);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // subpanelOCRMenu
            // 
            this.subpanelOCRMenu.Controls.Add(this.btnFileDatabase);
            this.subpanelOCRMenu.Controls.Add(this.btnFileUpload);
            this.subpanelOCRMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelOCRMenu.Location = new System.Drawing.Point(0, 86);
            this.subpanelOCRMenu.Name = "subpanelOCRMenu";
            this.subpanelOCRMenu.Size = new System.Drawing.Size(290, 86);
            this.subpanelOCRMenu.TabIndex = 9;
            this.subpanelOCRMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.subpanelOCRMenu_Paint);
            // 
            // btnFileDatabase
            // 
            this.btnFileDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(225)))));
            this.btnFileDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileDatabase.FlatAppearance.BorderSize = 0;
            this.btnFileDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDatabase.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDatabase.ForeColor = System.Drawing.Color.White;
            this.btnFileDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnFileDatabase.Image")));
            this.btnFileDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDatabase.Location = new System.Drawing.Point(0, 43);
            this.btnFileDatabase.Name = "btnFileDatabase";
            this.btnFileDatabase.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnFileDatabase.Size = new System.Drawing.Size(290, 43);
            this.btnFileDatabase.TabIndex = 3;
            this.btnFileDatabase.Text = "          Archive Database";
            this.btnFileDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDatabase.UseVisualStyleBackColor = false;
            this.btnFileDatabase.Click += new System.EventHandler(this.btnFileDatabase_Click);
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(225)))));
            this.btnFileUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileUpload.FlatAppearance.BorderSize = 0;
            this.btnFileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileUpload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileUpload.ForeColor = System.Drawing.Color.White;
            this.btnFileUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnFileUpload.Image")));
            this.btnFileUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileUpload.Location = new System.Drawing.Point(0, 0);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnFileUpload.Size = new System.Drawing.Size(290, 43);
            this.btnFileUpload.TabIndex = 2;
            this.btnFileUpload.Text = "          Upload To Archive";
            this.btnFileUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileUpload.UseVisualStyleBackColor = false;
            this.btnFileUpload.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProjectManagement
            // 
            this.btnProjectManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProjectManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjectManagement.FlatAppearance.BorderSize = 0;
            this.btnProjectManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectManagement.ForeColor = System.Drawing.Color.White;
            this.btnProjectManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectManagement.Image")));
            this.btnProjectManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectManagement.Location = new System.Drawing.Point(0, 172);
            this.btnProjectManagement.Name = "btnProjectManagement";
            this.btnProjectManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProjectManagement.Size = new System.Drawing.Size(290, 43);
            this.btnProjectManagement.TabIndex = 10;
            this.btnProjectManagement.Text = "          Task Management";
            this.btnProjectManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectManagement.UseVisualStyleBackColor = true;
            this.btnProjectManagement.Click += new System.EventHandler(this.btnProjectManagement_Click);
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.sideMenuPanel.Controls.Add(this.btnUsers);
            this.sideMenuPanel.Controls.Add(this.btnPermits);
            this.sideMenuPanel.Controls.Add(this.btnCommunityComplaints);
            this.sideMenuPanel.Controls.Add(this.btnEmployeeManagement);
            this.sideMenuPanel.Controls.Add(this.subpanelProjManagement);
            this.sideMenuPanel.Controls.Add(this.btnProjectManagement);
            this.sideMenuPanel.Controls.Add(this.subpanelOCRMenu);
            this.sideMenuPanel.Controls.Add(this.btnFileManagement);
            this.sideMenuPanel.Controls.Add(this.btnHome);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(290, 703);
            this.sideMenuPanel.TabIndex = 0;
            this.sideMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideMenuPanel_Paint);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 430);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(290, 43);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "          User Management";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPermits
            // 
            this.btnPermits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPermits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermits.FlatAppearance.BorderSize = 0;
            this.btnPermits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermits.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermits.ForeColor = System.Drawing.Color.White;
            this.btnPermits.Image = ((System.Drawing.Image)(resources.GetObject("btnPermits.Image")));
            this.btnPermits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermits.Location = new System.Drawing.Point(0, 387);
            this.btnPermits.Name = "btnPermits";
            this.btnPermits.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPermits.Size = new System.Drawing.Size(290, 43);
            this.btnPermits.TabIndex = 14;
            this.btnPermits.Text = "          Permits";
            this.btnPermits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermits.UseVisualStyleBackColor = true;
            this.btnPermits.Click += new System.EventHandler(this.btnPermits_Click);
            // 
            // btnCommunityComplaints
            // 
            this.btnCommunityComplaints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCommunityComplaints.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommunityComplaints.FlatAppearance.BorderSize = 0;
            this.btnCommunityComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommunityComplaints.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunityComplaints.ForeColor = System.Drawing.Color.White;
            this.btnCommunityComplaints.Image = ((System.Drawing.Image)(resources.GetObject("btnCommunityComplaints.Image")));
            this.btnCommunityComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommunityComplaints.Location = new System.Drawing.Point(0, 344);
            this.btnCommunityComplaints.Name = "btnCommunityComplaints";
            this.btnCommunityComplaints.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCommunityComplaints.Size = new System.Drawing.Size(290, 43);
            this.btnCommunityComplaints.TabIndex = 13;
            this.btnCommunityComplaints.Text = "          Community Complaints";
            this.btnCommunityComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommunityComplaints.UseVisualStyleBackColor = true;
            this.btnCommunityComplaints.Click += new System.EventHandler(this.btnCommunityComplaints_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmployeeManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManagement.Image")));
            this.btnEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(0, 301);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployeeManagement.Size = new System.Drawing.Size(290, 43);
            this.btnEmployeeManagement.TabIndex = 12;
            this.btnEmployeeManagement.Text = "          Employee Management";
            this.btnEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // subpanelProjManagement
            // 
            this.subpanelProjManagement.Controls.Add(this.button1);
            this.subpanelProjManagement.Controls.Add(this.button2);
            this.subpanelProjManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelProjManagement.Location = new System.Drawing.Point(0, 215);
            this.subpanelProjManagement.Name = "subpanelProjManagement";
            this.subpanelProjManagement.Size = new System.Drawing.Size(290, 86);
            this.subpanelProjManagement.TabIndex = 11;
            this.subpanelProjManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.subpanelProjManagement_Paint);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(225)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 43);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(290, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "          Task Database";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(225)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(290, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "          Ongoing Tasks";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnFileManagement
            // 
            this.btnFileManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileManagement.FlatAppearance.BorderSize = 0;
            this.btnFileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileManagement.ForeColor = System.Drawing.Color.White;
            this.btnFileManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnFileManagement.Image")));
            this.btnFileManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManagement.Location = new System.Drawing.Point(0, 43);
            this.btnFileManagement.Name = "btnFileManagement";
            this.btnFileManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFileManagement.Size = new System.Drawing.Size(290, 43);
            this.btnFileManagement.TabIndex = 8;
            this.btnFileManagement.Text = "          File Archive";
            this.btnFileManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManagement.UseVisualStyleBackColor = true;
            this.btnFileManagement.Click += new System.EventHandler(this.btnFileManagement_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1458, 703);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.subpanelOCRMenu.ResumeLayout(false);
            this.sideMenuPanel.ResumeLayout(false);
            this.subpanelProjManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel subpanelOCRMenu;
        private System.Windows.Forms.Button btnFileDatabase;
        private System.Windows.Forms.Button btnFileUpload;
        private System.Windows.Forms.Button btnProjectManagement;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button btnFileManagement;
        private System.Windows.Forms.Panel subpanelProjManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnCommunityComplaints;
        private System.Windows.Forms.Button btnPermits;
        private System.Windows.Forms.Button btnUsers;
    }
}