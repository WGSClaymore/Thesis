namespace Thesis.UpdatedForms
{
    partial class formTaskDatabase
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
            this.lblTaskDatabase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaskDatabase
            // 
            this.lblTaskDatabase.AutoSize = true;
            this.lblTaskDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaskDatabase.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDatabase.ForeColor = System.Drawing.Color.Black;
            this.lblTaskDatabase.Location = new System.Drawing.Point(0, 0);
            this.lblTaskDatabase.Name = "lblTaskDatabase";
            this.lblTaskDatabase.Size = new System.Drawing.Size(437, 86);
            this.lblTaskDatabase.TabIndex = 11;
            this.lblTaskDatabase.Text = "Task Database";
            // 
            // formTaskDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 691);
            this.Controls.Add(this.lblTaskDatabase);
            this.Name = "formTaskDatabase";
            this.Text = "formTaskManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskDatabase;
    }
}