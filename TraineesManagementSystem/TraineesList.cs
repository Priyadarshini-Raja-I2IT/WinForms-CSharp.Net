using System.ComponentModel;

namespace Trainees_Management_System
{
  
    internal class TraineesList
    {
        private static BindingList<Trainee> trainees = new BindingList<Trainee>();
        private static BindingList<Trainee> Trainees { get => trainees; set => trainees = value; }

        public BindingList<Trainee> AddTrainee(Trainee trainee)
        {
            Trainees.Add(trainee);
            return Trainees;
        }

        public BindingList<Trainee> GetAllTrainees()
        {
            return Trainees;
        }
    }
}
