namespace Thesis
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.subpanelOCRMenu = new System.Windows.Forms.Panel();
            this.btnFileDatabase = new System.Windows.Forms.Button();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnProjectManagement = new System.Windows.Forms.Button();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.subpanelProjManagement = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFileManagement = new System.Windows.Forms.Button();
            this.panelChildForm.SuspendLayout();
            this.subpanelOCRMenu.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            this.subpanelProjManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(290, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1168, 703);
            this.panelChildForm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(297, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 86);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to CENRO!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(488, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CENRO DBMS";
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(290, 43);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
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
            this.btnFileDatabase.Location = new System.Drawing.Point(0, 43);
            this.btnFileDatabase.Name = "btnFileDatabase";
            this.btnFileDatabase.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnFileDatabase.Size = new System.Drawing.Size(290, 43);
            this.btnFileDatabase.TabIndex = 3;
            this.btnFileDatabase.Text = "File Database";
            this.btnFileDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDatabase.UseVisualStyleBackColor = false;
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
            this.btnFileUpload.Location = new System.Drawing.Point(0, 0);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnFileUpload.Size = new System.Drawing.Size(290, 43);
            this.btnFileUpload.TabIndex = 2;
            this.btnFileUpload.Text = "File Upload";
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
            this.btnProjectManagement.Location = new System.Drawing.Point(0, 172);
            this.btnProjectManagement.Name = "btnProjectManagement";
            this.btnProjectManagement.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnProjectManagement.Size = new System.Drawing.Size(290, 43);
            this.btnProjectManagement.TabIndex = 10;
            this.btnProjectManagement.Text = "Project Management";
            this.btnProjectManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectManagement.UseVisualStyleBackColor = true;
            this.btnProjectManagement.Click += new System.EventHandler(this.btnProjectManagement_Click);
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.RoyalBlue;
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
            // 
            // subpanelProjManagement
            // 
            this.subpanelProjManagement.Controls.Add(this.button1);
            this.subpanelProjManagement.Controls.Add(this.button2);
            this.subpanelProjManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelProjManagement.Location = new System.Drawing.Point(0, 215);
            this.subpanelProjManagement.Name = "subpanelProjManagement";
            this.subpanelProjManagement.Size = new System.Drawing.Size(290, 87);
            this.subpanelProjManagement.TabIndex = 11;
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
            this.button1.Location = new System.Drawing.Point(0, 43);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(290, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Project Database";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
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
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(290, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Project Status";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnFileManagement
            // 
            this.btnFileManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileManagement.FlatAppearance.BorderSize = 0;
            this.btnFileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileManagement.ForeColor = System.Drawing.Color.White;
            this.btnFileManagement.Location = new System.Drawing.Point(0, 43);
            this.btnFileManagement.Name = "btnFileManagement";
            this.btnFileManagement.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnFileManagement.Size = new System.Drawing.Size(290, 43);
            this.btnFileManagement.TabIndex = 8;
            this.btnFileManagement.Text = "File Management";
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDashboard";
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.subpanelOCRMenu.ResumeLayout(false);
            this.sideMenuPanel.ResumeLayout(false);
            this.subpanelProjManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
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
    }
}