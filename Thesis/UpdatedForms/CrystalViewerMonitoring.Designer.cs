
namespace Thesis.UpdatedForms
{
    partial class CrystalViewerMonitoring
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
            this.CRViewerMonitor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crNewMonitor1 = new Thesis.UpdatedForms.crNewMonitor();
            this.SuspendLayout();
            // 
            // CRViewerMonitor
            // 
            this.CRViewerMonitor.ActiveViewIndex = 0;
            this.CRViewerMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewerMonitor.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewerMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewerMonitor.Location = new System.Drawing.Point(0, 0);
            this.CRViewerMonitor.Name = "CRViewerMonitor";
            this.CRViewerMonitor.ReportSource = this.crNewMonitor1;
            this.CRViewerMonitor.Size = new System.Drawing.Size(800, 450);
            this.CRViewerMonitor.TabIndex = 0;
            // 
            // CrystalViewerMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRViewerMonitor);
            this.Name = "CrystalViewerMonitoring";
            this.Text = "CrystalViewerMonitoring";
            this.ResumeLayout(false);

        }

        #endregion
        private crNewMonitor crNewMonitor1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewerMonitor;
    }
}