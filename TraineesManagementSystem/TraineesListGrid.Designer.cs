﻿namespace Trainees_Management_System
{
    partial class TraineesListGrid
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.traineesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.traineesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // traineesGrid
            // 
            this.traineesGrid.AllowUserToAddRows = false;
            this.traineesGrid.AllowUserToOrderColumns = true;
            this.traineesGrid.AutoGenerateColumns = false;
            this.traineesGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.traineesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.traineesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.Delete,
            this.Update});
            this.traineesGrid.DataSource = this.traineeBindingSource;
            this.traineesGrid.Location = new System.Drawing.Point(12, 129);
            this.traineesGrid.Name = "traineesGrid";
            this.traineesGrid.RowHeadersVisible = false;
            this.traineesGrid.RowHeadersWidth = 62;
            this.traineesGrid.RowTemplate.Height = 28;
            this.traineesGrid.Size = new System.Drawing.Size(1104, 350);
            this.traineesGrid.TabIndex = 0;
            this.traineesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineesGrid_CellContentClick);
            this.traineesGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.traineesGrid_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trainees List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle9;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 59;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 150;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 8;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mobileNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile Number";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.addressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateOfBirthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 150;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qualificationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationDataGridViewTextBoxColumn.Width = 150;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(Trainees_Management_System.Trainee);
            // 
            // TraineesListGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1228, 594);
            this.Controls.Add(this.traineesGrid);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TraineesListGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TraineesListGrid";
            ((System.ComponentModel.ISupportInitialize)(this.traineesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView traineesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}