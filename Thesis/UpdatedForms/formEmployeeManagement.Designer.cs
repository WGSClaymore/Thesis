namespace Thesis.UpdatedForms
{
    partial class formEmployeeManagement
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
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.txtEmplname = new System.Windows.Forms.TextBox();
            this.txtEmpfname = new System.Windows.Forms.TextBox();
            this.txtEmpmname = new System.Windows.Forms.TextBox();
            this.lblEmplname = new System.Windows.Forms.Label();
            this.lblEmpfname = new System.Windows.Forms.Label();
            this.lblEmpmname = new System.Windows.Forms.Label();
            this.cmbSuffix = new System.Windows.Forms.ComboBox();
            this.lblEmpSuffix = new System.Windows.Forms.Label();
            this.lblEmpposition = new System.Windows.Forms.Label();
            this.cmbEmpPosition = new System.Windows.Forms.ComboBox();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfo.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeInfo.Location = new System.Drawing.Point(0, 0);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(664, 86);
            this.lblEmployeeInfo.TabIndex = 11;
            this.lblEmployeeInfo.Text = "Employee Information";
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(647, 85);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(720, 594);
            this.dgvEmployeeInfo.TabIndex = 12;
            // 
            // txtEmplname
            // 
            this.txtEmplname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmplname.Location = new System.Drawing.Point(105, 115);
            this.txtEmplname.Name = "txtEmplname";
            this.txtEmplname.Size = new System.Drawing.Size(184, 29);
            this.txtEmplname.TabIndex = 13;
            // 
            // txtEmpfname
            // 
            this.txtEmpfname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpfname.Location = new System.Drawing.Point(390, 115);
            this.txtEmpfname.Name = "txtEmpfname";
            this.txtEmpfname.Size = new System.Drawing.Size(184, 29);
            this.txtEmpfname.TabIndex = 14;
            // 
            // txtEmpmname
            // 
            this.txtEmpmname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpmname.Location = new System.Drawing.Point(125, 174);
            this.txtEmpmname.Name = "txtEmpmname";
            this.txtEmpmname.Size = new System.Drawing.Size(184, 29);
            this.txtEmpmname.TabIndex = 15;
            // 
            // lblEmplname
            // 
            this.lblEmplname.AutoSize = true;
            this.lblEmplname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplname.Location = new System.Drawing.Point(12, 115);
            this.lblEmplname.Name = "lblEmplname";
            this.lblEmplname.Size = new System.Drawing.Size(87, 21);
            this.lblEmplname.TabIndex = 16;
            this.lblEmplname.Text = "Last Name:";
            // 
            // lblEmpfname
            // 
            this.lblEmpfname.AutoSize = true;
            this.lblEmpfname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpfname.Location = new System.Drawing.Point(295, 118);
            this.lblEmpfname.Name = "lblEmpfname";
            this.lblEmpfname.Size = new System.Drawing.Size(89, 21);
            this.lblEmpfname.TabIndex = 17;
            this.lblEmpfname.Text = "First Name:";
            // 
            // lblEmpmname
            // 
            this.lblEmpmname.AutoSize = true;
            this.lblEmpmname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpmname.Location = new System.Drawing.Point(12, 177);
            this.lblEmpmname.Name = "lblEmpmname";
            this.lblEmpmname.Size = new System.Drawing.Size(107, 21);
            this.lblEmpmname.TabIndex = 18;
            this.lblEmpmname.Text = "Middle Name:";
            // 
            // cmbSuffix
            // 
            this.cmbSuffix.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuffix.FormattingEnabled = true;
            this.cmbSuffix.Items.AddRange(new object[] {
            "Jr.",
            "Sr.",
            "II",
            "III",
            "IV",
            "V",
            "None"});
            this.cmbSuffix.Location = new System.Drawing.Point(390, 174);
            this.cmbSuffix.Name = "cmbSuffix";
            this.cmbSuffix.Size = new System.Drawing.Size(78, 29);
            this.cmbSuffix.TabIndex = 19;
            // 
            // lblEmpSuffix
            // 
            this.lblEmpSuffix.AutoSize = true;
            this.lblEmpSuffix.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSuffix.Location = new System.Drawing.Point(332, 177);
            this.lblEmpSuffix.Name = "lblEmpSuffix";
            this.lblEmpSuffix.Size = new System.Drawing.Size(52, 21);
            this.lblEmpSuffix.TabIndex = 20;
            this.lblEmpSuffix.Text = "Suffix:";
            // 
            // lblEmpposition
            // 
            this.lblEmpposition.AutoSize = true;
            this.lblEmpposition.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpposition.Location = new System.Drawing.Point(12, 241);
            this.lblEmpposition.Name = "lblEmpposition";
            this.lblEmpposition.Size = new System.Drawing.Size(68, 21);
            this.lblEmpposition.TabIndex = 21;
            this.lblEmpposition.Text = "Position:";
            // 
            // cmbEmpPosition
            // 
            this.cmbEmpPosition.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpPosition.FormattingEnabled = true;
            this.cmbEmpPosition.Items.AddRange(new object[] {
            "Jr.",
            "Sr.",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbEmpPosition.Location = new System.Drawing.Point(86, 238);
            this.cmbEmpPosition.Name = "cmbEmpPosition";
            this.cmbEmpPosition.Size = new System.Drawing.Size(138, 29);
            this.cmbEmpPosition.TabIndex = 19;
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDOB.Location = new System.Drawing.Point(241, 241);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(100, 21);
            this.lblEmpDOB.TabIndex = 21;
            this.lblEmpDOB.Text = "Date of Birth:";
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmpDOB.Location = new System.Drawing.Point(347, 238);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(200, 29);
            this.dtpEmpDOB.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 640);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEmpEdit.FlatAppearance.BorderSize = 0;
            this.btnEmpEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnEmpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpEdit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpEdit.ForeColor = System.Drawing.Color.White;
            this.btnEmpEdit.Location = new System.Drawing.Point(127, 640);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(105, 39);
            this.btnEmpEdit.TabIndex = 24;
            this.btnEmpEdit.Text = "Edit";
            this.btnEmpEdit.UseVisualStyleBackColor = false;
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEmpDelete.FlatAppearance.BorderSize = 0;
            this.btnEmpDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnEmpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDelete.ForeColor = System.Drawing.Color.White;
            this.btnEmpDelete.Location = new System.Drawing.Point(238, 640);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(105, 39);
            this.btnEmpDelete.TabIndex = 25;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = false;
            // 
            // formEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 691);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpEmpDOB);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.lblEmpposition);
            this.Controls.Add(this.lblEmpSuffix);
            this.Controls.Add(this.cmbEmpPosition);
            this.Controls.Add(this.cmbSuffix);
            this.Controls.Add(this.lblEmpmname);
            this.Controls.Add(this.lblEmpfname);
            this.Controls.Add(this.lblEmplname);
            this.Controls.Add(this.txtEmpmname);
            this.Controls.Add(this.txtEmpfname);
            this.Controls.Add(this.txtEmplname);
            this.Controls.Add(this.dgvEmployeeInfo);
            this.Controls.Add(this.lblEmployeeInfo);
            this.Name = "formEmployeeManagement";
            this.Text = "formEmployeeManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.TextBox txtEmplname;
        private System.Windows.Forms.TextBox txtEmpfname;
        private System.Windows.Forms.TextBox txtEmpmname;
        private System.Windows.Forms.Label lblEmplname;
        private System.Windows.Forms.Label lblEmpfname;
        private System.Windows.Forms.Label lblEmpmname;
        private System.Windows.Forms.ComboBox cmbSuffix;
        private System.Windows.Forms.Label lblEmpSuffix;
        private System.Windows.Forms.Label lblEmpposition;
        private System.Windows.Forms.ComboBox cmbEmpPosition;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpDelete;
    }
}