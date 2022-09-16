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
            this.btnOCR = new System.Windows.Forms.Button();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.btnPermits = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnFIles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTItleBar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOCR
            // 
            this.btnOCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOCR.FlatAppearance.BorderSize = 0;
            this.btnOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOCR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOCR.Location = new System.Drawing.Point(0, 0);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(220, 66);
            this.btnOCR.TabIndex = 1;
            this.btnOCR.Text = "Upload a File";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEmployee.Location = new System.Drawing.Point(0, 273);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(220, 69);
            this.BtnEmployee.TabIndex = 5;
            this.BtnEmployee.Text = "Employee";
            this.BtnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnPermits
            // 
            this.btnPermits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermits.FlatAppearance.BorderSize = 0;
            this.btnPermits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermits.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPermits.Location = new System.Drawing.Point(0, 204);
            this.btnPermits.Name = "btnPermits";
            this.btnPermits.Size = new System.Drawing.Size(220, 69);
            this.btnPermits.TabIndex = 4;
            this.btnPermits.Text = "Permits";
            this.btnPermits.UseVisualStyleBackColor = true;
            // 
            // btnComplaints
            // 
            this.btnComplaints.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComplaints.Location = new System.Drawing.Point(0, 66);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(220, 69);
            this.btnComplaints.TabIndex = 3;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            // 
            // btnFIles
            // 
            this.btnFIles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFIles.FlatAppearance.BorderSize = 0;
            this.btnFIles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFIles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFIles.Location = new System.Drawing.Point(0, 135);
            this.btnFIles.Name = "btnFIles";
            this.btnFIles.Size = new System.Drawing.Size(220, 69);
            this.btnFIles.TabIndex = 2;
            this.btnFIles.Text = "Files";
            this.btnFIles.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.BtnEmployee);
            this.panel1.Controls.Add(this.btnPermits);
            this.panel1.Controls.Add(this.btnFIles);
            this.panel1.Controls.Add(this.btnComplaints);
            this.panel1.Controls.Add(this.btnOCR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 602);
            this.panel1.TabIndex = 7;
            // 
            // panelTItleBar
            // 
            this.panelTItleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTItleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTItleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTItleBar.Name = "panelTItleBar";
            this.panelTItleBar.Size = new System.Drawing.Size(854, 100);
            this.panelTItleBar.TabIndex = 8;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 602);
            this.Controls.Add(this.panelTItleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Button BtnEmployee;
        private System.Windows.Forms.Button btnPermits;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnFIles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTItleBar;
    }
}