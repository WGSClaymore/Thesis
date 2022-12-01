﻿namespace Thesis.UpdatedForms
{
    partial class formTaskAssignment
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
            this.lblTaskAssignment = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTaskAssign = new System.Windows.Forms.DataGridView();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRespPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaskAssignment
            // 
            this.lblTaskAssignment.AutoSize = true;
            this.lblTaskAssignment.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskAssignment.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaskAssignment.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskAssignment.ForeColor = System.Drawing.Color.Black;
            this.lblTaskAssignment.Location = new System.Drawing.Point(0, 0);
            this.lblTaskAssignment.Name = "lblTaskAssignment";
            this.lblTaskAssignment.Size = new System.Drawing.Size(505, 86);
            this.lblTaskAssignment.TabIndex = 13;
            this.lblTaskAssignment.Text = "Task Assignment";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(177, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 39);
            this.btnEdit.TabIndex = 93;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 92;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTaskAssign
            // 
            this.dgvTaskAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskAssign.Location = new System.Drawing.Point(484, 330);
            this.dgvTaskAssign.Name = "dgvTaskAssign";
            this.dgvTaskAssign.RowHeadersWidth = 51;
            this.dgvTaskAssign.Size = new System.Drawing.Size(889, 322);
            this.dgvTaskAssign.TabIndex = 91;
            this.dgvTaskAssign.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskAssign_CellClick);
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(929, 94);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.RowHeadersWidth = 51;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(443, 229);
            this.dgvEmployeeInfo.TabIndex = 90;
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(484, 94);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.Size = new System.Drawing.Size(440, 229);
            this.dgvTask.TabIndex = 89;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(152, 151);
            this.txtEmpName.Multiline = true;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(314, 159);
            this.txtEmpName.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Responsible Person:";
            // 
            // txtRespPerson
            // 
            this.txtRespPerson.Location = new System.Drawing.Point(153, 124);
            this.txtRespPerson.Name = "txtRespPerson";
            this.txtRespPerson.Size = new System.Drawing.Size(314, 20);
            this.txtRespPerson.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Employee Name/s:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(153, 94);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(314, 20);
            this.txtTaskName.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Task Name:";
            // 
            // formTaskAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 660);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTaskAssign);
            this.Controls.Add(this.dgvEmployeeInfo);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRespPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTaskAssignment);
            this.Name = "formTaskAssignment";
            this.Text = "formTaskAssignment";
            this.Load += new System.EventHandler(this.formTaskAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskAssignment;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTaskAssign;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRespPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label1;
    }
}