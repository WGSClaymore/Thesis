﻿namespace Thesis
{
    partial class formOCR
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
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(625, 415);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "Select File";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(713, 415);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(89, 389);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(699, 20);
            this.txtFileLocation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Selected:";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(713, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Return";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // formOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnFileSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formOCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload a File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}

