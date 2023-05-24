
namespace Thesis.UpdatedForms
{
    partial class formDocOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRelTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRelBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTaskDatabase = new System.Windows.Forms.Label();
            this.dgvDocOut = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDocID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(303, 321);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 38);
            this.btnEdit.TabIndex = 87;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(171, 322);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 38);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(157, 265);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(397, 29);
            this.dtpDate.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 84;
            this.label5.Text = "Released Documents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 82;
            this.label3.Text = "Date";
            // 
            // txtRelTo
            // 
            this.txtRelTo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelTo.Location = new System.Drawing.Point(157, 218);
            this.txtRelTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRelTo.Name = "txtRelTo";
            this.txtRelTo.Size = new System.Drawing.Size(469, 29);
            this.txtRelTo.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 80;
            this.label4.Text = "Released To:";
            // 
            // txtRelBy
            // 
            this.txtRelBy.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelBy.Location = new System.Drawing.Point(157, 168);
            this.txtRelBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRelBy.Name = "txtRelBy";
            this.txtRelBy.Size = new System.Drawing.Size(469, 29);
            this.txtRelBy.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 78;
            this.label2.Text = "Released By:";
            // 
            // txtDocTitle
            // 
            this.txtDocTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocTitle.Location = new System.Drawing.Point(157, 123);
            this.txtDocTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocTitle.Name = "txtDocTitle";
            this.txtDocTitle.Size = new System.Drawing.Size(469, 29);
            this.txtDocTitle.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Document Title:";
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
            this.lblTaskDatabase.Size = new System.Drawing.Size(626, 86);
            this.lblTaskDatabase.TabIndex = 299;
            this.lblTaskDatabase.Text = "Released Documents";
            // 
            // dgvDocOut
            // 
            this.dgvDocOut.AllowUserToResizeColumns = false;
            this.dgvDocOut.AllowUserToResizeRows = false;
            this.dgvDocOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocOut.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocOut.ColumnHeadersHeight = 80;
            this.dgvDocOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocOut.Location = new System.Drawing.Point(649, 70);
            this.dgvDocOut.MinimumSize = new System.Drawing.Size(20, 0);
            this.dgvDocOut.MultiSelect = false;
            this.dgvDocOut.Name = "dgvDocOut";
            this.dgvDocOut.ReadOnly = true;
            this.dgvDocOut.RowHeadersVisible = false;
            this.dgvDocOut.RowHeadersWidth = 51;
            this.dgvDocOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocOut.Size = new System.Drawing.Size(902, 979);
            this.dgvDocOut.TabIndex = 358;
            this.dgvDocOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocOut_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "Document ID:";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocID.Location = new System.Drawing.Point(155, 86);
            this.lblDocID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(0, 21);
            this.lblDocID.TabIndex = 76;
            // 
            // formDocOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1563, 1055);
            this.Controls.Add(this.dgvDocOut);
            this.Controls.Add(this.lblTaskDatabase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRelTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRelBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocTitle);
            this.Controls.Add(this.lblDocID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formDocOut";
            this.Text = "formDocOut";
            this.Load += new System.EventHandler(this.formDocOut_Load);
            this.Click += new System.EventHandler(this.formDocOut_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRelTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRelBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTaskDatabase;
        private System.Windows.Forms.DataGridView dgvDocOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDocID;
    }
}