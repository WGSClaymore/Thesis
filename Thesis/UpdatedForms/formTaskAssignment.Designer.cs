namespace Thesis.UpdatedForms
{
    partial class formTaskAssignment
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
            this.lblTaskAssignment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaskAssignment
            // 
            this.lblTaskAssignment.AutoSize = true;
            this.lblTaskAssignment.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskAssignment.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaskAssignment.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskAssignment.ForeColor = System.Drawing.Color.Black;
            this.lblTaskAssignment.Location = new System.Drawing.Point(0, 0);
            this.lblTaskAssignment.Name = "lblTaskAssignment";
            this.lblTaskAssignment.Size = new System.Drawing.Size(505, 86);
            this.lblTaskAssignment.TabIndex = 13;
            this.lblTaskAssignment.Text = "Task Assignment";
            // 
            // formTaskAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 660);
            this.Controls.Add(this.lblTaskAssignment);
            this.Name = "formTaskAssignment";
            this.Text = "formTaskAssignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskAssignment;
    }
}