using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainees_Management_System
{
  
    internal class TraineesList
    {
        private static List<Trainee> trainees = new List<Trainee>();
        private static List<Trainee> Trainees { get => trainees; set => trainees = value; }

        public List<Trainee> addTrainee(Trainee trainee)
        {
            Trainees.Add(trainee);
            return Trainees;
        }

        public List<Trainee> getAllTrainees()
        {
            return Trainees;
        }
    }
}
