namespace Thesis.UpdatedForms
{
    partial class formComplaintStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.btnDeleteComplaint = new System.Windows.Forms.Button();
            this.btnEditComplaint = new System.Windows.Forms.Button();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.dtpUpdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Nature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.CompName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
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
            this.lblEmployeeInfo.Size = new System.Drawing.Size(645, 106);
            this.lblEmployeeInfo.TabIndex = 12;
            this.lblEmployeeInfo.Text = "Complaint Status";
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComplaint.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplaint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplaint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComplaint.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComplaint.GridColor = System.Drawing.Color.White;
            this.dgvComplaint.Location = new System.Drawing.Point(701, 132);
            this.dgvComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComplaint.MinimumSize = new System.Drawing.Size(20, 0);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.RowHeadersWidth = 51;
            this.dgvComplaint.Size = new System.Drawing.Size(933, 457);
            this.dgvComplaint.TabIndex = 93;
            this.dgvComplaint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaint_CellClick);
            // 
            // btnDeleteComplaint
            // 
            this.btnDeleteComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnDeleteComplaint.FlatAppearance.BorderSize = 0;
            this.btnDeleteComplaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnDeleteComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComplaint.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComplaint.ForeColor = System.Drawing.Color.White;
            this.btnDeleteComplaint.Location = new System.Drawing.Point(577, 1068);
            this.btnDeleteComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.Size = new System.Drawing.Size(140, 48);
            this.btnDeleteComplaint.TabIndex = 89;
            this.btnDeleteComplaint.Text = "Delete";
            this.btnDeleteComplaint.UseVisualStyleBackColor = false;
            this.btnDeleteComplaint.Click += new System.EventHandler(this.btnDeleteComplaint_Click);
            // 
            // btnEditComplaint
            // 
            this.btnEditComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEditComplaint.FlatAppearance.BorderSize = 0;
            this.btnEditComplaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnEditComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditComplaint.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditComplaint.ForeColor = System.Drawing.Color.White;
            this.btnEditComplaint.Location = new System.Drawing.Point(577, 956);
            this.btnEditComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditComplaint.Name = "btnEditComplaint";
            this.btnEditComplaint.Size = new System.Drawing.Size(140, 48);
            this.btnEditComplaint.TabIndex = 88;
            this.btnEditComplaint.Text = "Edit";
            this.btnEditComplaint.UseVisualStyleBackColor = false;
            this.btnEditComplaint.Click += new System.EventHandler(this.btnEditComplaint_Click);
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnAddComplaint.FlatAppearance.BorderSize = 0;
            this.btnAddComplaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnAddComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComplaint.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComplaint.ForeColor = System.Drawing.Color.White;
            this.btnAddComplaint.Location = new System.Drawing.Point(577, 1012);
            this.btnAddComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(140, 48);
            this.btnAddComplaint.TabIndex = 87;
            this.btnAddComplaint.Text = "Update";
            this.btnAddComplaint.UseVisualStyleBackColor = false;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // dgvFinal
            // 
            this.dgvFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinal.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinal.GridColor = System.Drawing.Color.White;
            this.dgvFinal.Location = new System.Drawing.Point(701, 596);
            this.dgvFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFinal.MinimumSize = new System.Drawing.Size(20, 0);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.RowHeadersWidth = 51;
            this.dgvFinal.Size = new System.Drawing.Size(933, 965);
            this.dgvFinal.TabIndex = 103;
            this.dgvFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinal_CellClick);
            // 
            // dtpUpdate
            // 
            this.dtpUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUpdate.Location = new System.Drawing.Point(233, 805);
            this.dtpUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpUpdate.Name = "dtpUpdate";
            this.dtpUpdate.Size = new System.Drawing.Size(336, 34);
            this.dtpUpdate.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 810);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 28);
            this.label10.TabIndex = 131;
            this.label10.Text = "Date Updated:";
            // 
            // TelNo
            // 
            this.TelNo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelNo.Location = new System.Drawing.Point(233, 502);
            this.TelNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(336, 34);
            this.TelNo.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 506);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 129;
            this.label3.Text = "Telephone No:";
            // 
            // Desc
            // 
            this.Desc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc.Location = new System.Drawing.Point(233, 560);
            this.Desc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Desc.Multiline = true;
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(336, 171);
            this.Desc.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 562);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 127;
            this.label7.Text = "Description:";
            // 
            // Nature
            // 
            this.Nature.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nature.Location = new System.Drawing.Point(233, 439);
            this.Nature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nature.Name = "Nature";
            this.Nature.Size = new System.Drawing.Size(336, 34);
            this.Nature.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 443);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 28);
            this.label6.TabIndex = 125;
            this.label6.Text = "Nature of Complaint:";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(233, 265);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(336, 143);
            this.Address.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 123;
            this.label5.Text = "Address:";
            // 
            // Remarks
            // 
            this.Remarks.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks.Location = new System.Drawing.Point(233, 976);
            this.Remarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Remarks.Multiline = true;
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(336, 178);
            this.Remarks.TabIndex = 122;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 976);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 28);
            this.label9.TabIndex = 121;
            this.label9.Text = "Remarks:";
            // 
            // Action
            // 
            this.Action.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action.Location = new System.Drawing.Point(233, 862);
            this.Action.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Action.Multiline = true;
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(336, 93);
            this.Action.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 864);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 28);
            this.label8.TabIndex = 119;
            this.label8.Text = "Action/s Taken:";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Cancelled",
            "Resolved"});
            this.Status.Location = new System.Drawing.Point(235, 202);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(336, 36);
            this.Status.TabIndex = 118;
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 117;
            this.label2.Text = "Status:";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(233, 758);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(336, 34);
            this.Date.TabIndex = 116;
            // 
            // CompName
            // 
            this.CompName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompName.Location = new System.Drawing.Point(235, 132);
            this.CompName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompName.Name = "CompName";
            this.CompName.Size = new System.Drawing.Size(336, 34);
            this.CompName.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 766);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 114;
            this.label4.Text = "Date Submitted:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 113;
            this.label1.Text = "Complaintant Name:";
            // 
            // formComplaintStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1651, 1325);
            this.Controls.Add(this.dtpUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Nature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CompName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFinal);
            this.Controls.Add(this.dgvComplaint);
            this.Controls.Add(this.btnDeleteComplaint);
            this.Controls.Add(this.btnEditComplaint);
            this.Controls.Add(this.btnAddComplaint);
            this.Controls.Add(this.lblEmployeeInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formComplaintStatus";
            this.Text = "formComplaintStatus";
            this.Load += new System.EventHandler(this.formComplaintStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.DataGridView dgvComplaint;
        private System.Windows.Forms.Button btnDeleteComplaint;
        private System.Windows.Forms.Button btnEditComplaint;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.DataGridView dgvFinal;
        private System.Windows.Forms.DateTimePicker dtpUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Remarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Action;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox CompName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}