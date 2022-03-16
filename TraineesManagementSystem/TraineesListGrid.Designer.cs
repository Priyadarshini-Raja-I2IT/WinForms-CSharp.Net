namespace TraineesManagement.windows
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.traineesGrid = new System.Windows.Forms.DataGridView();
            this.traineeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.freshersDataSet = new TraineesManagement.windows.FreshersDataSet();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.traineeTableAdapter = new TraineesManagement.windows.FreshersDataSetTableAdapters.TraineeTableAdapter();
            this.freshersDataSet1 = new TraineesManagement.windows.FreshersDataSet1();
            this.fresherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fresherTableAdapter = new TraineesManagement.windows.FreshersDataSet1TableAdapters.FresherTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.traineesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // traineesGrid
            // 
            this.traineesGrid.AllowUserToAddRows = false;
            this.traineesGrid.AllowUserToOrderColumns = true;
            this.traineesGrid.AutoGenerateColumns = false;
            this.traineesGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.traineesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.traineesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Delete,
            this.Update});
            this.traineesGrid.DataSource = this.fresherBindingSource;
            this.traineesGrid.Location = new System.Drawing.Point(12, 129);
            this.traineesGrid.Name = "traineesGrid";
            this.traineesGrid.ReadOnly = true;
            this.traineesGrid.RowHeadersVisible = false;
            this.traineesGrid.RowHeadersWidth = 62;
            this.traineesGrid.RowTemplate.Height = 28;
            this.traineesGrid.Size = new System.Drawing.Size(1104, 350);
            this.traineesGrid.TabIndex = 0;
            this.traineesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineesGrid_CellContentClick);
            // 
            // traineeBindingSource1
            // 
            this.traineeBindingSource1.DataMember = "Trainee";
            this.traineeBindingSource1.DataSource = this.freshersDataSet;
            // 
            // freshersDataSet
            // 
            this.freshersDataSet.DataSetName = "FreshersDataSet";
            this.freshersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // traineeTableAdapter
            // 
            this.traineeTableAdapter.ClearBeforeFill = true;
            // 
            // freshersDataSet1
            // 
            this.freshersDataSet1.DataSetName = "FreshersDataSet1";
            this.freshersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fresherBindingSource
            // 
            this.fresherBindingSource.DataMember = "Fresher";
            this.fresherBindingSource.DataSource = this.freshersDataSet1;
            // 
            // fresherTableAdapter
            // 
            this.fresherTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mobile_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mobile Number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_of_birth";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date of Birth";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qualification";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qualification";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
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
            // TraineesListGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            //this.Load += new System.EventHandler(this.TraineesListGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traineesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView traineesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private FreshersDataSet freshersDataSet;
        private System.Windows.Forms.BindingSource traineeBindingSource1;
        private FreshersDataSetTableAdapters.TraineeTableAdapter traineeTableAdapter;
        private FreshersDataSet1 freshersDataSet1;
        private System.Windows.Forms.BindingSource fresherBindingSource;
        private FreshersDataSet1TableAdapters.FresherTableAdapter fresherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}