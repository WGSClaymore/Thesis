namespace Thesis.UpdatedForms
{
    partial class formUserManagement
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
            this.lblUsers = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDNumber = new System.Windows.Forms.Label();
            this.lblAccessType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsers.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.Black;
            this.lblUsers.Location = new System.Drawing.Point(0, 0);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(697, 106);
            this.lblUsers.TabIndex = 11;
            this.lblUsers.Text = "User Management";
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(771, 106);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(961, 730);
            this.dgvUsers.TabIndex = 12;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(16, 106);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(79, 28);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "User ID:";
            // 
            // lblUserIDNumber
            // 
            this.lblUserIDNumber.AutoSize = true;
            this.lblUserIDNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDNumber.Location = new System.Drawing.Point(109, 106);
            this.lblUserIDNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIDNumber.Name = "lblUserIDNumber";
            this.lblUserIDNumber.Size = new System.Drawing.Size(20, 28);
            this.lblUserIDNumber.TabIndex = 14;
            this.lblUserIDNumber.Text = "-";
            // 
            // lblAccessType
            // 
            this.lblAccessType.AutoSize = true;
            this.lblAccessType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessType.Location = new System.Drawing.Point(16, 158);
            this.lblAccessType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessType.Name = "lblAccessType";
            this.lblAccessType.Size = new System.Drawing.Size(119, 28);
            this.lblAccessType.TabIndex = 15;
            this.lblAccessType.Text = "Access Type:";
            // 
            // formUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 850);
            this.Controls.Add(this.lblAccessType);
            this.Controls.Add(this.lblUserIDNumber);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formUserManagement";
            this.Text = "formUserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDNumber;
        private System.Windows.Forms.Label lblAccessType;
    }
}