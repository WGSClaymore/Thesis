
namespace Thesis.Forms
{
    partial class Update_Complaints
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
            this.btnUpdateUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbATUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRmrkIp = new System.Windows.Forms.TextBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Complaintdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Complaintdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateUp
            // 
            this.btnUpdateUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUp.Location = new System.Drawing.Point(120, 395);
            this.btnUpdateUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateUp.Name = "btnUpdateUp";
            this.btnUpdateUp.Size = new System.Drawing.Size(129, 37);
            this.btnUpdateUp.TabIndex = 1;
            this.btnUpdateUp.Text = "Update";
            this.btnUpdateUp.UseVisualStyleBackColor = true;
            this.btnUpdateUp.Click += new System.EventHandler(this.btnUpdateUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date Resolved:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Actions Taken:";
            // 
            // tbATUp
            // 
            this.tbATUp.Location = new System.Drawing.Point(164, 97);
            this.tbATUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbATUp.Multiline = true;
            this.tbATUp.Name = "tbATUp";
            this.tbATUp.Size = new System.Drawing.Size(321, 93);
            this.tbATUp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remarks:";
            // 
            // tbRmrkIp
            // 
            this.tbRmrkIp.Location = new System.Drawing.Point(164, 198);
            this.tbRmrkIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRmrkIp.Multiline = true;
            this.tbRmrkIp.Name = "tbRmrkIp";
            this.tbRmrkIp.Size = new System.Drawing.Size(321, 158);
            this.tbRmrkIp.TabIndex = 8;
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Location = new System.Drawing.Point(164, 53);
            this.dtp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(321, 27);
            this.dtp2.TabIndex = 94;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Resolved",
            "Unresolved"});
            this.Status.Location = new System.Drawing.Point(164, 13);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(321, 28);
            this.Status.TabIndex = 97;
            // 
            // Complaintdgv
            // 
            this.Complaintdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Complaintdgv.Location = new System.Drawing.Point(492, 11);
            this.Complaintdgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Complaintdgv.Name = "Complaintdgv";
            this.Complaintdgv.RowHeadersWidth = 51;
            this.Complaintdgv.RowTemplate.Height = 24;
            this.Complaintdgv.Size = new System.Drawing.Size(992, 421);
            this.Complaintdgv.TabIndex = 98;
            // 
            // Update_Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 769);
            this.Controls.Add(this.Complaintdgv);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRmrkIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbATUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateUp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Update_Complaints";
            this.Text = "Update Complaints";
            this.Load += new System.EventHandler(this.Update_Complaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Complaintdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbATUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRmrkIp;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.DataGridView Complaintdgv;
    }
}