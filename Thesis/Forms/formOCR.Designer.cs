namespace Thesis
{
    partial class formOCR
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
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OCR = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OCR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFileSelect.Location = new System.Drawing.Point(811, 506);
            this.btnFileSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(100, 28);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "Select File";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Location = new System.Drawing.Point(919, 506);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Autofill";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFileLocation.Location = new System.Drawing.Point(195, 474);
            this.txtFileLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(931, 22);
            this.txtFileLocation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Selected:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(719, 75);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(417, 83);
            this.txtTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(1027, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Autofill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // OCR
            // 
            this.OCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OCR.Location = new System.Drawing.Point(12, 11);
            this.OCR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OCR.Name = "OCR";
            this.OCR.RowHeadersWidth = 51;
            this.OCR.RowTemplate.Height = 24;
            this.OCR.Size = new System.Drawing.Size(464, 439);
            this.OCR.TabIndex = 82;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(974, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 83;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OCR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnFileSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formOCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload a File";
            this.Load += new System.EventHandler(this.formOCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OCR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OCR;
        private System.Windows.Forms.Button button2;
    }
}

