namespace Thesis.UpdatedForms
{
    partial class formFileDatabase
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
            this.lblFileDatabase = new System.Windows.Forms.Label();
            this.dgvFileDatabase = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileDatabase
            // 
            this.lblFileDatabase.AutoSize = true;
            this.lblFileDatabase.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDatabase.Location = new System.Drawing.Point(12, 9);
            this.lblFileDatabase.Name = "lblFileDatabase";
            this.lblFileDatabase.Size = new System.Drawing.Size(307, 65);
            this.lblFileDatabase.TabIndex = 1;
            this.lblFileDatabase.Text = "File Database";
            // 
            // dgvFileDatabase
            // 
            this.dgvFileDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileDatabase.Location = new System.Drawing.Point(606, 76);
            this.dgvFileDatabase.Name = "dgvFileDatabase";
            this.dgvFileDatabase.Size = new System.Drawing.Size(686, 560);
            this.dgvFileDatabase.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(602, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 21);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search by Name:";
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.Location = new System.Drawing.Point(735, 41);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(557, 29);
            this.txtFileLocation.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(19, 175);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(106, 21);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Search Filters:";
            // 
            // formFileDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 650);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvFileDatabase);
            this.Controls.Add(this.lblFileDatabase);
            this.Name = "formFileDatabase";
            this.Text = "formFileDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileDatabase;
        private System.Windows.Forms.DataGridView dgvFileDatabase;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label lblFilter;
    }
}