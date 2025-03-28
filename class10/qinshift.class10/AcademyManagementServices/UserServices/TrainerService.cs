using AcademyLManagementDomain;
using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;

namespace AcademyManagementServices.UserServices
{
    public class TrainerService
    {
        private DataAccess _dataAccess { get; set; }
        public TrainerService()
        {
            _dataAccess = new DataAccess();
        }

        //login
        public Trainer TrainerLogin(string username, string password)
        {
            Trainer trainerFromDb = _dataAccess.GetTrainer(username, password);
            if (trainerFromDb == null)
            {
                throw new Exception("Invalid credentials");
            }
            return trainerFromDb;
        }
        public List<string> GetTrainerUsers(Role role, Trainer loggedTrainer)
        {
            return _dataAccess.GetUsernames(role, loggedTrainer);
        }
    }
}
