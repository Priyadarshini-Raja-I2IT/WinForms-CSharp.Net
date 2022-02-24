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
    public partial class TraineesListGrid : Form
    {
        private readonly BindingList<Trainee> _trainees = new TraineesList().GetAllTrainees();

        public TraineesListGrid()
        {
            InitializeComponent();
            LoadGridView();
        }

        private void LoadGridView()
        {
            traineesGrid.DataSource = _trainees;

            traineesGrid.Columns[0].HeaderText = "Name";
            traineesGrid.Columns[1].HeaderText = "Mobile_Number";
            traineesGrid.Columns[2].HeaderText = "Address";
            traineesGrid.Columns[3].HeaderText = "Date_Of_Birth";
            traineesGrid.Columns[4].HeaderText = "Qualifications";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedRow = traineesGrid.CurrentCell.RowIndex;
            string traineeName = (string)traineesGrid.Rows[selectedRow].Cells[0].Value;
            foreach(Trainee trainee in _trainees.ToList())
            {
                if(trainee.Name == traineeName)
                    _trainees.Remove(trainee);
            }
                
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            TraineeForm fr = new TraineeForm();
            int row = traineesGrid.CurrentRow.Index;
            fr.Shown += (senderfr, efr) =>
            {
                // I did null check because I used the same form as Form2 :) 
                // You can probably omit this check.
                if (fr.Owner == null) return;

                var ownerForm = fr.Owner as TraineesListGrid;
                fr.Name = ownerForm.traineesGrid[0, row].Value.ToString();
            };
            fr.Show(this);

        }

       
    }
}
