using System;
using System.Windows.Forms;

using TraineesManagement.data;
using TraineesManagement.model;

namespace TraineesManagement.windows
{
    public partial class TraineesListGrid : Form
    {
        ITraineesDBManager traineesDBManager = new TraineesDBManager();

        public TraineesListGrid()
        {
            InitializeComponent();
            LoadGridView();
        }

        public void LoadGridView()
        {
            traineesGrid.DataSource = traineesDBManager.GetAllTrainees();
        }

        private void traineesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (traineesGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = Convert.ToInt32(traineesGrid.CurrentRow.Cells[0].Value);

                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (0 < traineesDBManager.DeleteTrainee(id))
                        MessageBox.Show($"Trainee {id} deleted successfully!");
                    LoadGridView();
                }
            }

            if (traineesGrid.Columns[e.ColumnIndex].Name == "Update")
            {
                int id = Convert.ToInt32(traineesGrid.CurrentRow.Cells[0].Value);
                Trainee traineeToUpdate = traineesDBManager.GetTraineeById(id);
                TraineeForm traineeForm = new TraineeForm(traineeToUpdate)
                {
                    MdiParent = MdiParent,
                    Dock = DockStyle.Fill
                };
                traineeForm.Show();
                this.Close();
            }
        }
    }
}