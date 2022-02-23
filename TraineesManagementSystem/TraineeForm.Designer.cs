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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.MobileNumberTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DOBDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DegreesList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputValidation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qualification";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(239, 36);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(245, 26);
            this.NameTxtBox.TabIndex = 5;
            this.NameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxValidation);
            // 
            // MobileNumberTxtBox
            // 
            this.MobileNumberTxtBox.Location = new System.Drawing.Point(239, 97);
            this.MobileNumberTxtBox.Name = "MobileNumberTxtBox";
            this.MobileNumberTxtBox.Size = new System.Drawing.Size(245, 26);
            this.MobileNumberTxtBox.TabIndex = 6;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(239, 153);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(245, 96);
            this.AddressTxtBox.TabIndex = 7;
            // 
            // DOBDatePicker
            // 
            this.DOBDatePicker.Location = new System.Drawing.Point(239, 289);
            this.DOBDatePicker.Name = "DOBDatePicker";
            this.DOBDatePicker.Size = new System.Drawing.Size(245, 26);
            this.DOBDatePicker.TabIndex = 10;
            this.DOBDatePicker.Value = new System.DateTime(2022, 2, 23, 15, 36, 39, 0);
            // 
            // DegreesList
            // 
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
            this.DegreesList.Location = new System.Drawing.Point(239, 344);
            this.DegreesList.Name = "DegreesList";
            this.DegreesList.Size = new System.Drawing.Size(245, 28);
            this.DegreesList.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputValidation
            // 
            this.inputValidation.ContainerControl = this;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 549);
            this.Controls.Add(this.button1);
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
            this.Text = "TraineeForm";
            ((System.ComponentModel.ISupportInitialize)(this.inputValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox MobileNumberTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.DateTimePicker DOBDatePicker;
        private System.Windows.Forms.ComboBox DegreesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider inputValidation;
    }
}