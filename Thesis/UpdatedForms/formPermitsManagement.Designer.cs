namespace Thesis.UpdatedForms
{
    partial class formPermitsManagement
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
            this.lblPermitManagement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPermitManagement
            // 
            this.lblPermitManagement.AutoSize = true;
            this.lblPermitManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblPermitManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPermitManagement.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermitManagement.ForeColor = System.Drawing.Color.Black;
            this.lblPermitManagement.Location = new System.Drawing.Point(0, 0);
            this.lblPermitManagement.Name = "lblPermitManagement";
            this.lblPermitManagement.Size = new System.Drawing.Size(246, 86);
            this.lblPermitManagement.TabIndex = 19;
            this.lblPermitManagement.Text = "Permits";
            // 
            // formPermitsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 691);
            this.Controls.Add(this.lblPermitManagement);
            this.Name = "formPermitsManagement";
            this.Text = "formPermitsManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPermitManagement;
    }
}