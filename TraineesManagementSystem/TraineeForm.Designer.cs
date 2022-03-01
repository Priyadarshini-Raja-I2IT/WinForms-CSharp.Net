namespace Trainees_Management_System
{
    partial class TraineeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.MobileNumberTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DOBDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DegreesList = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.inputValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTraineeFormTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.Location = new System.Drawing.Point(626, 120);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(245, 30);
            this.NameTxtBox.TabIndex = 5;
            this.NameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxValidation);
            // 
            // MobileNumberTxtBox
            // 
            this.MobileNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumberTxtBox.Location = new System.Drawing.Point(626, 174);
            this.MobileNumberTxtBox.Name = "MobileNumberTxtBox";
            this.MobileNumberTxtBox.Size = new System.Drawing.Size(245, 30);
            this.MobileNumberTxtBox.TabIndex = 6;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxtBox.Location = new System.Drawing.Point(626, 241);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(245, 96);
            this.AddressTxtBox.TabIndex = 7;
            // 
            // DOBDatePicker
            // 
            this.DOBDatePicker.CustomFormat = "";
            this.DOBDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBDatePicker.Location = new System.Drawing.Point(626, 374);
            this.DOBDatePicker.Name = "DOBDatePicker";
            this.DOBDatePicker.Size = new System.Drawing.Size(245, 30);
            this.DOBDatePicker.TabIndex = 10;
            this.DOBDatePicker.Value = new System.DateTime(2022, 3, 1, 23, 2, 6, 0);
            // 
            // DegreesList
            // 
            this.DegreesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DegreesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreesList.FormattingEnabled = true;
            this.DegreesList.Items.AddRange(new object[] {
            "BCA",
            "B.Sc",
            "B.Tech",
            "BE",
            "MCA",
            "M.Sc",
            "M.Tech",
            "ME",
            "PhD",
            "Others"});
            this.DegreesList.Location = new System.Drawing.Point(626, 438);
            this.DegreesList.Name = "DegreesList";
            this.DegreesList.Size = new System.Drawing.Size(245, 33);
            this.DegreesList.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(494, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inputValidation
            // 
            this.inputValidation.ContainerControl = this;
            // 
            // lblTraineeFormTitle
            // 
            this.lblTraineeFormTitle.AutoSize = true;
            this.lblTraineeFormTitle.BackColor = System.Drawing.Color.Silver;
            this.lblTraineeFormTitle.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeFormTitle.Location = new System.Drawing.Point(435, 9);
            this.lblTraineeFormTitle.Name = "lblTraineeFormTitle";
            this.lblTraineeFormTitle.Size = new System.Drawing.Size(270, 55);
            this.lblTraineeFormTitle.TabIndex = 13;
            this.lblTraineeFormTitle.Text = "Trainee Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qualification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile Number";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(622, 78);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 14;
            this.lblId.Visible = false;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 594);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTraineeFormTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DegreesList);
            this.Controls.Add(this.DOBDatePicker);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.MobileNumberTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TraineeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TraineeForm";
            ((System.ComponentModel.ISupportInitialize)(this.inputValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox MobileNumberTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.DateTimePicker DOBDatePicker;
        private System.Windows.Forms.ComboBox DegreesList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider inputValidation;
        private System.Windows.Forms.Label lblTraineeFormTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
    }
}