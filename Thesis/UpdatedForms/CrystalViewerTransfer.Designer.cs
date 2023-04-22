
namespace Thesis.UpdatedForms
{
    partial class CrystalViewerTransfer
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
            this.CRViewerTransfer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crNewTransfer2 = new Thesis.UpdatedForms.crNewTransfer();
            this.crNewTransfer1 = new Thesis.UpdatedForms.crNewTransfer();
            this.SuspendLayout();
            // 
            // CRViewerTransfer
            // 
            this.CRViewerTransfer.ActiveViewIndex = 0;
            this.CRViewerTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewerTransfer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewerTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewerTransfer.Location = new System.Drawing.Point(0, 0);
            this.CRViewerTransfer.Name = "CRViewerTransfer";
            this.CRViewerTransfer.ReportSource = this.crNewTransfer2;
            this.CRViewerTransfer.Size = new System.Drawing.Size(800, 450);
            this.CRViewerTransfer.TabIndex = 0;
            // 
            // CrystalViewerTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRViewerTransfer);
            this.Name = "CrystalViewerTransfer";
            this.Text = "CrystalViewerTransfer";
            this.ResumeLayout(false);

        }

        #endregion
        private crNewTransfer crNewTransfer1;
        private crNewTransfer crNewTransfer2;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewerTransfer;
    }
}