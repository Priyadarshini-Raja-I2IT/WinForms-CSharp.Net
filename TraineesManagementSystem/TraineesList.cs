using System;
using System.ComponentModel;

namespace Trainees_Management_System
{
  
    internal class TraineesList
    {
        private static BindingList<Trainee> trainees = new BindingList<Trainee>();
        private static BindingList<Trainee> Trainees { get => trainees; set => trainees = value; }

        public Trainee AddTrainee(Trainee trainee)
        {
            Trainees.Add(trainee);            
            return trainee;
        }

        public BindingList<Trainee> GetAllTrainees()
        {
            return Trainees;
        }

        internal Trainee EditTrainee(int id, string name, long mobileNumber, string address, DateTime dateOfBirth, string qualification)
        {
            Trainee trainee = null;
            foreach (Trainee person in Trainees)
            {
                if (person.Id == id)
                {
                    person.Name = name;
                    person.MobileNumber = mobileNumber;
                    person.Address = address;
                    person.DateOfBirth = dateOfBirth;
                    person.Qualification = qualification;
                    trainee = person;
                    break;
                }
            }

            return trainee;
        }
    }
}
