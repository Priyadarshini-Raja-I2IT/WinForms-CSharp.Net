using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineesManagement.data;
using TraineesManagement.model;

namespace TraineesManagement.service
{
    public class TraineeService : ITraineeService
    {
        ITraineesDBManager traineesDBManager = new TraineesDBManager();

        public int AddTrainee(Trainee trainee)
        {
            return traineesDBManager.InsertTrainee(trainee);
        }
        public List<Trainee> GetAllTrainees()
        {
            return traineesDBManager.GetAllTrainees().ToList();
        }

        public int DeleteTrainee(int id)
        {
            return traineesDBManager.DeleteTrainee(id);
        }

        public Trainee GetTraineeById(int id)
        {
            return traineesDBManager.GetTraineeById(id);
        }

        public int UpdateTrainee(Trainee trainee)
        {
            return traineesDBManager.UpdateTrainee(trainee);
        }
    }
}
