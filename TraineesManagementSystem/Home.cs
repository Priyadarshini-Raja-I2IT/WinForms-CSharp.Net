using System;
using System.Windows.Forms;

namespace TraineesManagement.windows
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddNewTraineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "TraineeForm")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                TraineeForm traineeForm = new TraineeForm
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                traineeForm.Show();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient client)
                {
                    client.BackColor = this.BackColor;
                    break;
                }
            }
        }

        TraineesListGrid traineesListGrid;
        private void TraineesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "TraineesListGrid")
                {
                    IsOpen = true;
                    form.Focus();
                    form.Update();
                    break;
                }
            }

            if (IsOpen == false)
            {
                traineesListGrid = new TraineesListGrid
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                traineesListGrid.Show();
                traineesListGrid.Update();
            }
        }
    }
}