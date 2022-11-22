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
            this.dgvPermit = new System.Windows.Forms.DataGridView();
            this.btnDeletePermit = new System.Windows.Forms.Button();
            this.btnEditPermit = new System.Windows.Forms.Button();
            this.btnAddPermit = new System.Windows.Forms.Button();
            this.lblAccessType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.dtpPermitIssued = new System.Windows.Forms.DateTimePicker();
            this.dtpDateApproved = new System.Windows.Forms.DateTimePicker();
            this.txtReviewed = new System.Windows.Forms.TextBox();
            this.dtpPermitExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermit)).BeginInit();
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
            // dgvPermit
            // 
            this.dgvPermit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermit.Location = new System.Drawing.Point(579, 85);
            this.dgvPermit.Name = "dgvPermit";
            this.dgvPermit.Size = new System.Drawing.Size(720, 594);
            this.dgvPermit.TabIndex = 20;
            // 
            // btnDeletePermit
            // 
            this.btnDeletePermit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletePermit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnDeletePermit.FlatAppearance.BorderSize = 0;
            this.btnDeletePermit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnDeletePermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePermit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePermit.ForeColor = System.Drawing.Color.White;
            this.btnDeletePermit.Location = new System.Drawing.Point(234, 640);
            this.btnDeletePermit.Name = "btnDeletePermit";
            this.btnDeletePermit.Size = new System.Drawing.Size(105, 39);
            this.btnDeletePermit.TabIndex = 28;
            this.btnDeletePermit.Text = "Delete";
            this.btnDeletePermit.UseVisualStyleBackColor = false;
            // 
            // btnEditPermit
            // 
            this.btnEditPermit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditPermit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEditPermit.FlatAppearance.BorderSize = 0;
            this.btnEditPermit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnEditPermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPermit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPermit.ForeColor = System.Drawing.Color.White;
            this.btnEditPermit.Location = new System.Drawing.Point(123, 640);
            this.btnEditPermit.Name = "btnEditPermit";
            this.btnEditPermit.Size = new System.Drawing.Size(105, 39);
            this.btnEditPermit.TabIndex = 27;
            this.btnEditPermit.Text = "Edit";
            this.btnEditPermit.UseVisualStyleBackColor = false;
            // 
            // btnAddPermit
            // 
            this.btnAddPermit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPermit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnAddPermit.FlatAppearance.BorderSize = 0;
            this.btnAddPermit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnAddPermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPermit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPermit.ForeColor = System.Drawing.Color.White;
            this.btnAddPermit.Location = new System.Drawing.Point(12, 640);
            this.btnAddPermit.Name = "btnAddPermit";
            this.btnAddPermit.Size = new System.Drawing.Size(105, 39);
            this.btnAddPermit.TabIndex = 26;
            this.btnAddPermit.Text = "Add";
            this.btnAddPermit.UseVisualStyleBackColor = false;
            // 
            // lblAccessType
            // 
            this.lblAccessType.AutoSize = true;
            this.lblAccessType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessType.Location = new System.Drawing.Point(12, 164);
            this.lblAccessType.Name = "lblAccessType";
            this.lblAccessType.Size = new System.Drawing.Size(105, 21);
            this.lblAccessType.TabIndex = 30;
            this.lblAccessType.Text = "Permit Expiry:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Applicant Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Reviewed By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date Approved:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Date Issued:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicantName.Location = new System.Drawing.Point(156, 106);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(355, 29);
            this.txtApplicantName.TabIndex = 36;
            // 
            // dtpPermitIssued
            // 
            this.dtpPermitIssued.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPermitIssued.Location = new System.Drawing.Point(156, 209);
            this.dtpPermitIssued.Name = "dtpPermitIssued";
            this.dtpPermitIssued.Size = new System.Drawing.Size(168, 29);
            this.dtpPermitIssued.TabIndex = 38;
            // 
            // dtpDateApproved
            // 
            this.dtpDateApproved.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateApproved.Location = new System.Drawing.Point(156, 261);
            this.dtpDateApproved.Name = "dtpDateApproved";
            this.dtpDateApproved.Size = new System.Drawing.Size(168, 29);
            this.dtpDateApproved.TabIndex = 39;
            // 
            // txtReviewed
            // 
            this.txtReviewed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewed.Location = new System.Drawing.Point(156, 316);
            this.txtReviewed.Name = "txtReviewed";
            this.txtReviewed.Size = new System.Drawing.Size(355, 29);
            this.txtReviewed.TabIndex = 40;
            // 
            // dtpPermitExpiry
            // 
            this.dtpPermitExpiry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPermitExpiry.Location = new System.Drawing.Point(156, 158);
            this.dtpPermitExpiry.Name = "dtpPermitExpiry";
            this.dtpPermitExpiry.Size = new System.Drawing.Size(168, 29);
            this.dtpPermitExpiry.TabIndex = 41;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(345, 640);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 39);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // formPermitsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 691);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpPermitExpiry);
            this.Controls.Add(this.txtReviewed);
            this.Controls.Add(this.dtpDateApproved);
            this.Controls.Add(this.dtpPermitIssued);
            this.Controls.Add(this.txtApplicantName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccessType);
            this.Controls.Add(this.btnDeletePermit);
            this.Controls.Add(this.btnEditPermit);
            this.Controls.Add(this.btnAddPermit);
            this.Controls.Add(this.dgvPermit);
            this.Controls.Add(this.lblPermitManagement);
            this.Name = "formPermitsManagement";
            this.Text = "formPermitsManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPermitManagement;
        private System.Windows.Forms.DataGridView dgvPermit;
        private System.Windows.Forms.Button btnDeletePermit;
        private System.Windows.Forms.Button btnEditPermit;
        private System.Windows.Forms.Button btnAddPermit;
        private System.Windows.Forms.Label lblAccessType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.DateTimePicker dtpPermitIssued;
        private System.Windows.Forms.DateTimePicker dtpDateApproved;
        private System.Windows.Forms.TextBox txtReviewed;
        private System.Windows.Forms.DateTimePicker dtpPermitExpiry;
        private System.Windows.Forms.Button btnPrint;
    }
}