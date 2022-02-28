using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Trainees_Management_System
{
    public partial class TraineeForm : Form
    {
        private readonly TraineesList _traineesList = new TraineesList();
        BindingList<Trainee> trainees = new BindingList<Trainee>();
        private bool isEditable;

        public TraineeForm()
        {
            InitializeComponent();
            lblTraineeFormTitle.Text = "Add new trainee";
            isEditable = false;
        }

        internal TraineeForm(Trainee trainee)
        {
            InitializeComponent();
            lblTraineeFormTitle.Text = "Edit trainee details";
            isEditable = true;
            getDataToFormFields(trainee);
            btnSave.Text = "Save Changes";
        }

        private void getDataToFormFields(Trainee trainee)
        {
            lblId.Text = trainee.Id.ToString();
            NameTxtBox.Text = trainee.Name;
            MobileNumberTxtBox.Text = trainee.MobileNumber.ToString();
            AddressTxtBox.Text= trainee.Address;
            DOBDatePicker.Text = trainee.DateOfBirth.ToString();
            DegreesList.SelectedItem = trainee.Qualification;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isEditable)
            {
                int id = int.Parse(lblId.Text);
                string name = NameTxtBox.Text;
                long mobileNumber = long.Parse(MobileNumberTxtBox.Text);
                string address = AddressTxtBox.Text;
                DateTime dateOfBirth = this.DOBDatePicker.Value.Date;
                string qualification = DegreesList.SelectedItem.ToString();

                if(null != _traineesList.EditTrainee(id, name, mobileNumber, address, dateOfBirth, qualification))
                    MessageBox.Show($"Details of trainee {id} updated successfully");
                Close();

                
            } else
            {
                Trainee trainee = new Trainee
                {
                    Name = NameTxtBox.Text,
                    MobileNumber = Convert.ToInt64(MobileNumberTxtBox.Text),
                    Address = AddressTxtBox.Text,
                    DateOfBirth = this.DOBDatePicker.Value.Date,
                    Qualification = DegreesList.SelectedItem.ToString()
                };                

                if (_traineesList.AddTrainee(trainee) != null)
                {
                    MessageBox.Show("New Trainee added successfully");
                    clearForm();
                }
            }            
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
