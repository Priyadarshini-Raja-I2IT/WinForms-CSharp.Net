using System;
using System.Windows.Forms;

namespace Trainees_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        TraineeForm traineeForm;
        private void addNewTraineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traineeForm == null)
            {
                traineeForm = new TraineeForm();
                traineeForm.MdiParent = this;
                traineeForm.Show();
            }
            else
            {
                MessageBox.Show("You've already opened trainees form!");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (client != null)
                {
                    client.BackColor = this.BackColor;
                    break;
                }
            }
        }

        TraineesListGrid traineesListGrid;
        private void traineesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
                traineesListGrid = new TraineesListGrid();
                traineesListGrid.MdiParent = this;
                traineesListGrid.ShowDialog();            
        }
    }
}
