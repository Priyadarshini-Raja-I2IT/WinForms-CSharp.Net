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
        TraineesList traineesList = new TraineesList();
        public TraineesListGrid()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {            
            dataGridView1.DataSource = traineesList.getAllTrainees();
        }

    }
}
