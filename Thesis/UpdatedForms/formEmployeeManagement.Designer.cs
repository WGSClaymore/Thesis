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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAoA = new System.Windows.Forms.TextBox();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.lblEmpposition = new System.Windows.Forms.Label();
            this.lblEmpSuffix = new System.Windows.Forms.Label();
            this.lblEmpmname = new System.Windows.Forms.Label();
            this.lblEmpfname = new System.Windows.Forms.Label();
            this.lblEmplname = new System.Windows.Forms.Label();
            this.txtEmpmname = new System.Windows.Forms.TextBox();
            this.txtEmpfname = new System.Windows.Forms.TextBox();
            this.txtEmplname = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
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
            this.lblEmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(867, 101);
            this.dgvEmployeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.RowHeadersWidth = 51;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(960, 731);
            this.dgvEmployeeInfo.TabIndex = 12;
            this.dgvEmployeeInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfo_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(47, 555);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 48);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPos
            // 
            this.txtPos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(109, 276);
            this.txtPos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(222, 29);
            this.txtPos.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Employee ID No:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(196, 401);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(244, 29);
            this.txtEmpID.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Area of Assignment:";
            // 
            // txtAoA
            // 
            this.txtAoA.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAoA.Location = new System.Drawing.Point(213, 345);
            this.txtAoA.Margin = new System.Windows.Forms.Padding(4);
            this.txtAoA.Name = "txtAoA";
            this.txtAoA.Size = new System.Drawing.Size(462, 29);
            this.txtAoA.TabIndex = 42;
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmpDOB.Location = new System.Drawing.Point(474, 274);
            this.dtpEmpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(329, 29);
            this.dtpEmpDOB.TabIndex = 41;
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDOB.Location = new System.Drawing.Point(339, 278);
            this.lblEmpDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(100, 21);
            this.lblEmpDOB.TabIndex = 39;
            this.lblEmpDOB.Text = "Date of Birth:";
            // 
            // lblEmpposition
            // 
            this.lblEmpposition.AutoSize = true;
            this.lblEmpposition.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpposition.Location = new System.Drawing.Point(25, 278);
            this.lblEmpposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpposition.Name = "lblEmpposition";
            this.lblEmpposition.Size = new System.Drawing.Size(68, 21);
            this.lblEmpposition.TabIndex = 40;
            this.lblEmpposition.Text = "Position:";
            // 
            // lblEmpSuffix
            // 
            this.lblEmpSuffix.AutoSize = true;
            this.lblEmpSuffix.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSuffix.Location = new System.Drawing.Point(452, 199);
            this.lblEmpSuffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpSuffix.Name = "lblEmpSuffix";
            this.lblEmpSuffix.Size = new System.Drawing.Size(52, 21);
            this.lblEmpSuffix.TabIndex = 38;
            this.lblEmpSuffix.Text = "Suffix:";
            // 
            // lblEmpmname
            // 
            this.lblEmpmname.AutoSize = true;
            this.lblEmpmname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpmname.Location = new System.Drawing.Point(25, 199);
            this.lblEmpmname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpmname.Name = "lblEmpmname";
            this.lblEmpmname.Size = new System.Drawing.Size(107, 21);
            this.lblEmpmname.TabIndex = 36;
            this.lblEmpmname.Text = "Middle Name:";
            // 
            // lblEmpfname
            // 
            this.lblEmpfname.AutoSize = true;
            this.lblEmpfname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpfname.Location = new System.Drawing.Point(402, 126);
            this.lblEmpfname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpfname.Name = "lblEmpfname";
            this.lblEmpfname.Size = new System.Drawing.Size(89, 21);
            this.lblEmpfname.TabIndex = 35;
            this.lblEmpfname.Text = "First Name:";
            // 
            // lblEmplname
            // 
            this.lblEmplname.AutoSize = true;
            this.lblEmplname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplname.Location = new System.Drawing.Point(25, 123);
            this.lblEmplname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmplname.Name = "lblEmplname";
            this.lblEmplname.Size = new System.Drawing.Size(87, 21);
            this.lblEmplname.TabIndex = 34;
            this.lblEmplname.Text = "Last Name:";
            // 
            // txtEmpmname
            // 
            this.txtEmpmname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpmname.Location = new System.Drawing.Point(176, 195);
            this.txtEmpmname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpmname.Name = "txtEmpmname";
            this.txtEmpmname.Size = new System.Drawing.Size(244, 29);
            this.txtEmpmname.TabIndex = 33;
            // 
            // txtEmpfname
            // 
            this.txtEmpfname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpfname.Location = new System.Drawing.Point(529, 123);
            this.txtEmpfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpfname.Name = "txtEmpfname";
            this.txtEmpfname.Size = new System.Drawing.Size(244, 29);
            this.txtEmpfname.TabIndex = 32;
            // 
            // txtEmplname
            // 
            this.txtEmplname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmplname.Location = new System.Drawing.Point(149, 123);
            this.txtEmplname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmplname.Name = "txtEmplname";
            this.txtEmplname.Size = new System.Drawing.Size(244, 29);
            this.txtEmplname.TabIndex = 31;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuffix.Location = new System.Drawing.Point(529, 196);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(244, 29);
            this.txtSuffix.TabIndex = 47;
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEmpEdit.FlatAppearance.BorderSize = 0;
            this.btnEmpEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnEmpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpEdit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpEdit.ForeColor = System.Drawing.Color.White;
            this.btnEmpEdit.Location = new System.Drawing.Point(195, 555);
            this.btnEmpEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(140, 48);
            this.btnEmpEdit.TabIndex = 24;
            this.btnEmpEdit.Text = "Edit";
            this.btnEmpEdit.UseVisualStyleBackColor = false;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpEdit_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEmpDelete.FlatAppearance.BorderSize = 0;
            this.btnEmpDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnEmpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDelete.ForeColor = System.Drawing.Color.White;
            this.btnEmpDelete.Location = new System.Drawing.Point(343, 555);
            this.btnEmpDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(140, 48);
            this.btnEmpDelete.TabIndex = 25;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = false;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // formEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAoA);
            this.Controls.Add(this.dtpEmpDOB);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.lblEmpposition);
            this.Controls.Add(this.lblEmpSuffix);
            this.Controls.Add(this.lblEmpmname);
            this.Controls.Add(this.lblEmpfname);
            this.Controls.Add(this.lblEmplname);
            this.Controls.Add(this.txtEmpmname);
            this.Controls.Add(this.txtEmpfname);
            this.Controls.Add(this.txtEmplname);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployeeInfo);
            this.Controls.Add(this.lblEmployeeInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formEmployeeManagement";
            this.Text = "formEmployeeManagement";
            this.Load += new System.EventHandler(this.formEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAoA;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.Label lblEmpposition;
        private System.Windows.Forms.Label lblEmpSuffix;
        private System.Windows.Forms.Label lblEmpmname;
        private System.Windows.Forms.Label lblEmpfname;
        private System.Windows.Forms.Label lblEmplname;
        private System.Windows.Forms.TextBox txtEmpmname;
        private System.Windows.Forms.TextBox txtEmpfname;
        private System.Windows.Forms.TextBox txtEmplname;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpDelete;
    }
}