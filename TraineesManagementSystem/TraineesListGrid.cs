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
        }

        private void traineesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (traineesGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = Convert.ToInt32(traineesGrid.CurrentRow.Cells[0].Value);
                Trainee traineeToDelete = _trainees.FirstOrDefault(trainee => trainee.Id == id);
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _trainees.Remove(traineeToDelete);
                }
            }

            if (traineesGrid.Columns[e.ColumnIndex].Name == "Update")
            {
                int id = Convert.ToInt32(traineesGrid.CurrentRow.Cells[0].Value);
                Trainee traineeToUpdate = _trainees.FirstOrDefault(trainee => trainee.Id == id);
                TraineeForm traineeForm = new TraineeForm(traineeToUpdate)
                {
                    MdiParent = MdiParent,
                    Dock = DockStyle.Fill
                };
                traineeForm.Show();
            }
        }

        private void traineesGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            traineesGrid.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}