using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainees_Management_System
{
    public partial class TraineeForm : Form
    {
        public TraineeForm()
        {
            InitializeComponent();
        }

        private TraineesList _traineesList = new TraineesList();
        List<Trainee> trainees = new List<Trainee>();

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameTxtBox.Text;
            long mobileNumber = Convert.ToInt64(MobileNumberTxtBox.Text);
            string address = AddressTxtBox.Text;
            DateTime dateOfBirth = this.DOBDatePicker.Value.Date;
            string qualification = DegreesList.SelectedItem.ToString();

            trainees = _traineesList.addTrainee(new Trainee(name, mobileNumber, address, dateOfBirth, qualification));

            if(trainees != null)
            {
                MessageBox.Show("New Trainee added successfully");
            }
            clearForm();
        }

        private void clearForm()
        {
            NameTxtBox.Clear();
            MobileNumberTxtBox.Clear();
            AddressTxtBox.Clear();
            DOBDatePicker.Text = "";
            DegreesList.Text = "";
        }

        private void txtBoxValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxtBox.Text))
            {
                e.Cancel = true;
                NameTxtBox.Focus();
                inputValidation.SetError(NameTxtBox, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                inputValidation.SetError(NameTxtBox, "");
            }
        }
    }
}
