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
            this.btnPermitsPrint = new System.Windows.Forms.Button();
            this.lblAccessType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // btnPermitsPrint
            // 
            this.btnPermitsPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPermitsPrint.FlatAppearance.BorderSize = 0;
            this.btnPermitsPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnPermitsPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermitsPrint.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermitsPrint.ForeColor = System.Drawing.Color.White;
            this.btnPermitsPrint.Location = new System.Drawing.Point(345, 640);
            this.btnPermitsPrint.Name = "btnPermitsPrint";
            this.btnPermitsPrint.Size = new System.Drawing.Size(105, 39);
            this.btnPermitsPrint.TabIndex = 29;
            this.btnPermitsPrint.Text = "Delete";
            this.btnPermitsPrint.UseVisualStyleBackColor = false;
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
            // txtFileLocation
            // 
            this.txtFileLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.Location = new System.Drawing.Point(156, 106);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(355, 29);
            this.txtFileLocation.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 29);
            this.textBox1.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 29);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(156, 261);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 29);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(156, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 29);
            this.textBox2.TabIndex = 40;
            // 
            // formPermitsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 691);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccessType);
            this.Controls.Add(this.btnPermitsPrint);
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
        private System.Windows.Forms.Button btnPermitsPrint;
        private System.Windows.Forms.Label lblAccessType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox2;
    }
}