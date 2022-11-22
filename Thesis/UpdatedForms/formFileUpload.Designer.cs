namespace Thesis.UpdatedForms
{
    partial class formFileUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFileUpload));
            this.btnConfirmOCR = new System.Windows.Forms.Button();
            this.lblFilePreview = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateFileUpload = new System.Windows.Forms.Label();
            this.lblOrdinanceNumber = new System.Windows.Forms.Label();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFileTitle = new System.Windows.Forms.TextBox();
            this.dtpFileUpload = new System.Windows.Forms.DateTimePicker();
            this.lblHeader = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmOCR
            // 
            this.btnConfirmOCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnConfirmOCR.FlatAppearance.BorderSize = 0;
            this.btnConfirmOCR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnConfirmOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOCR.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOCR.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOCR.Location = new System.Drawing.Point(515, 135);
            this.btnConfirmOCR.Name = "btnConfirmOCR";
            this.btnConfirmOCR.Size = new System.Drawing.Size(105, 38);
            this.btnConfirmOCR.TabIndex = 1;
            this.btnConfirmOCR.Text = "Autofill";
            this.btnConfirmOCR.UseVisualStyleBackColor = false;
            this.btnConfirmOCR.Click += new System.EventHandler(this.btnConfirmOCR_Click);
            // 
            // lblFilePreview
            // 
            this.lblFilePreview.AutoSize = true;
            this.lblFilePreview.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePreview.Location = new System.Drawing.Point(645, 37);
            this.lblFilePreview.Name = "lblFilePreview";
            this.lblFilePreview.Size = new System.Drawing.Size(68, 21);
            this.lblFilePreview.TabIndex = 0;
            this.lblFilePreview.Text = "Preview:";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(24, 106);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(100, 21);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File Location:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 214);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblDateFileUpload
            // 
            this.lblDateFileUpload.AutoSize = true;
            this.lblDateFileUpload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFileUpload.Location = new System.Drawing.Point(8, 447);
            this.lblDateFileUpload.Name = "lblDateFileUpload";
            this.lblDateFileUpload.Size = new System.Drawing.Size(116, 21);
            this.lblDateFileUpload.TabIndex = 0;
            this.lblDateFileUpload.Text = "Date Uploaded:";
            // 
            // lblOrdinanceNumber
            // 
            this.lblOrdinanceNumber.AutoSize = true;
            this.lblOrdinanceNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinanceNumber.Location = new System.Drawing.Point(8, 375);
            this.lblOrdinanceNumber.Name = "lblOrdinanceNumber";
            this.lblOrdinanceNumber.Size = new System.Drawing.Size(166, 21);
            this.lblOrdinanceNumber.TabIndex = 0;
            this.lblOrdinanceNumber.Text = "File Type and Number:";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnFileSelect.FlatAppearance.BorderSize = 0;
            this.btnFileSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileSelect.ForeColor = System.Drawing.Color.White;
            this.btnFileSelect.Location = new System.Drawing.Point(404, 135);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(105, 38);
            this.btnFileSelect.TabIndex = 1;
            this.btnFileSelect.Text = "Select File";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.Location = new System.Drawing.Point(124, 103);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(496, 29);
            this.txtFileLocation.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(176, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 29);
            this.textBox1.TabIndex = 2;
            // 
            // txtFileTitle
            // 
            this.txtFileTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileTitle.Location = new System.Drawing.Point(124, 214);
            this.txtFileTitle.Multiline = true;
            this.txtFileTitle.Name = "txtFileTitle";
            this.txtFileTitle.Size = new System.Drawing.Size(496, 119);
            this.txtFileTitle.TabIndex = 2;
            // 
            // dtpFileUpload
            // 
            this.dtpFileUpload.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFileUpload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFileUpload.Location = new System.Drawing.Point(124, 441);
            this.dtpFileUpload.Name = "dtpFileUpload";
            this.dtpFileUpload.Size = new System.Drawing.Size(285, 29);
            this.dtpFileUpload.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(469, 86);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Archive Upload";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(719, 37);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(631, 983);
            this.axAcroPDF1.TabIndex = 10;
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Location = new System.Drawing.Point(28, 508);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(339, 512);
            this.dgvDocuments.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(373, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(487, 447);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(105, 39);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(202)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(373, 508);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 39);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // formFileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 1032);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dtpFileUpload);
            this.Controls.Add(this.txtFileTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.btnConfirmOCR);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.lblOrdinanceNumber);
            this.Controls.Add(this.lblDateFileUpload);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFilePreview);
            this.Controls.Add(this.lblFile);
            this.Name = "formFileUpload";
            this.Text = "formFileUpload";
            this.Load += new System.EventHandler(this.formFileUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmOCR;
        private System.Windows.Forms.Label lblFilePreview;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateFileUpload;
        private System.Windows.Forms.Label lblOrdinanceNumber;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtFileTitle;
        private System.Windows.Forms.DateTimePicker dtpFileUpload;
        private System.Windows.Forms.Label lblHeader;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnOpen;
    }
}