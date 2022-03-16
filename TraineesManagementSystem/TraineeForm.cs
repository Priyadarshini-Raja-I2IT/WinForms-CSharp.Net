using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using TraineesManagement.model;
using TraineesManagement.data;

namespace TraineesManagement.windows
{
    public partial class TraineeForm : Form
    {
        ITraineesDBManager traineesDBManager = new TraineesDBManager();
        TraineesListGrid gridView = new TraineesListGrid();

        private bool IsEditable;

        public TraineeForm()
        {
            InitializeComponent();
            lblTraineeFormTitle.Text = "Add new trainee";
            IsEditable = false;
        }

        internal TraineeForm(Trainee trainee)
        {
            InitializeComponent();
            lblTraineeFormTitle.Text = "Edit trainee details";
            IsEditable = true;
            getDataToFormFields(trainee);
            btnSave.Text = "Save Changes";
        }

        private void getDataToFormFields(Trainee trainee)
        {
            lblId.Text = trainee.Id.ToString();
            NameTxtBox.Text = trainee.Name;
            MobileNumberTxtBox.Text = trainee.MobileNumber.ToString();
            AddressTxtBox.Text = trainee.Address;
            DOBDatePicker.Text = trainee.DateOfBirth.ToString();
            DegreesList.SelectedItem = trainee.Qualification;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (IsEditable)
                {
                    int id = int.Parse(lblId.Text);
                    string name = NameTxtBox.Text;
                    string mobileNumber = MobileNumberTxtBox.Text;
                    string address = AddressTxtBox.Text;
                    DateTime dateOfBirth = this.DOBDatePicker.Value.Date;
                    string qualification = DegreesList.SelectedItem.ToString();                    

                    if (0 < traineesDBManager.UpdateTrainee(id, name, mobileNumber, dateOfBirth, qualification, address))
                        MessageBox.Show($"Trainee {id} updated successfully!");
                    Close();
                }
                else
                {
                    Trainee trainee = new Trainee
                    {
                        Name = NameTxtBox.Text,
                        MobileNumber = long.Parse(MobileNumberTxtBox.Text),
                        Address = AddressTxtBox.Text,
                        DateOfBirth = this.DOBDatePicker.Value.Date,
                        Qualification = DegreesList.SelectedItem.ToString()
                    };

                    if (0 < traineesDBManager.InsertTrainee(trainee))
                        MessageBox.Show("New Trainee created successfully!");
                    
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
            DegreesList.SelectedIndex = -1;
        }

        private void NameValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxtBox.Text))
            {
                e.Cancel = true;
                NameTxtBox.Focus();
                InputValidation.SetError(NameTxtBox, "Name should not be left blank!");
            }
            else if (!Regex.IsMatch(NameTxtBox.Text, @"^([a-zA-Z ]+)$"))
            {
                e.Cancel = true;
                NameTxtBox.Focus();
                InputValidation.SetError(NameTxtBox, "Name should not contain special characters or numbers!");
            }
            else
            {
                e.Cancel = false;
                InputValidation.SetError(NameTxtBox, "");
            }
        }

        private void MobileNumberValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MobileNumberTxtBox.Text))
            {
                e.Cancel = true;
                MobileNumberTxtBox.Focus();
                InputValidation.SetError(MobileNumberTxtBox, "Mobile number should not be left blank!");
            }
            else if (!Regex.IsMatch(MobileNumberTxtBox.Text, @"^((91)?[0]?[6-9][0-9]{9})$"))
            {
                e.Cancel = true;
                MobileNumberTxtBox.Focus();
                InputValidation.SetError(MobileNumberTxtBox, "Mobile number should contain 10 digits!");
            }
            else
            {
                e.Cancel = false;
                InputValidation.SetError(MobileNumberTxtBox, "");
            }
        }

        private void DOBValidation(object sender, CancelEventArgs e)
        {
            int age = DateTime.Now.Year - DOBDatePicker.Value.Year;
            if (DateTime.Now.DayOfYear < DOBDatePicker.Value.DayOfYear)
                age--;
            if(age < 18)
            {
                e.Cancel = true;
                DOBDatePicker.Focus();
                InputValidation.SetError(DOBDatePicker, "Age should be greater than 18!");
            }
        }

        private void QualificationValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DegreesList.Text))
            {
                e.Cancel = true;
                DegreesList.Focus();
                InputValidation.SetError(DegreesList, "You should select any one degree from the list!");
            }
            else
            {
                e.Cancel = false;
                InputValidation.SetError(DegreesList, "");
            }
        }
    }
}