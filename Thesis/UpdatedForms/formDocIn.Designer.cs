
namespace Thesis.UpdatedForms
{
    partial class formDocIn
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDocIn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecieved = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocIn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(237, 309);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 48);
            this.btnEdit.TabIndex = 74;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(68, 309);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 48);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(177, 221);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(278, 26);
            this.dtpDate.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Recieved Documents";
            // 
            // dgvDocIn
            // 
            this.dgvDocIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocIn.Location = new System.Drawing.Point(619, 13);
            this.dgvDocIn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocIn.Name = "dgvDocIn";
            this.dgvDocIn.RowHeadersWidth = 51;
            this.dgvDocIn.Size = new System.Drawing.Size(597, 642);
            this.dgvDocIn.TabIndex = 70;
            this.dgvDocIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocIn_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Date";
            // 
            // txtRecieved
            // 
            this.txtRecieved.Location = new System.Drawing.Point(177, 189);
            this.txtRecieved.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecieved.Name = "txtRecieved";
            this.txtRecieved.Size = new System.Drawing.Size(393, 22);
            this.txtRecieved.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Recieved By:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(177, 155);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(393, 22);
            this.txtSource.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Source of Document:";
            // 
            // txtDocTitle
            // 
            this.txtDocTitle.Location = new System.Drawing.Point(177, 121);
            this.txtDocTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocTitle.Name = "txtDocTitle";
            this.txtDocTitle.Size = new System.Drawing.Size(393, 22);
            this.txtDocTitle.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Document Title";
            // 
            // formDocIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 668);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDocIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecieved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocTitle);
            this.Controls.Add(this.label1);
            this.Name = "formDocIn";
            this.Text = "formDocIn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDocIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecieved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocTitle;
        private System.Windows.Forms.Label label1;
    }
}