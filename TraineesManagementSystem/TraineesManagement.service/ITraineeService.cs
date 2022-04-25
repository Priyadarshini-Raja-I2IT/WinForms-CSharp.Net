using System.Collections.Generic;
using TraineesManagement.model;

namespace TraineesManagement.service
{
    public interface ITraineeService
    {
        List<Trainee> GetAllTrainees();
        int DeleteTrainee(int id);
        int AddTrainee(Trainee trainee);
        Trainee GetTraineeById(int id);
        int UpdateTrainee(Trainee trainee);
    }
}