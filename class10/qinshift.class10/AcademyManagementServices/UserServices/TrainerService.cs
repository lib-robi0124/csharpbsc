using AcademyLManagementDomain;
using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyManagementServices.UserServices
{
    public class TrainerService
    {
        private DataAccess _dataAccess { get; set; }
        private Database _dataBase { get; set; }
        public TrainerService()
        {
            _dataAccess = new DataAccess();
            _dataBase = new Database();
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
        public Dictionary<string, int> SubjectsWithStudentCounts
        {
            get
            {
                Dictionary<string, int> subjectCounts = new Dictionary<string, int>();

                foreach (var student in _dataBase.Students)
                {
                    if (!string.IsNullOrEmpty(student.CurrentSubject))
                    {
                        if (subjectCounts.ContainsKey(student.CurrentSubject))
                        {
                            subjectCounts[student.CurrentSubject]++;
                        }
                        else
                        {
                            subjectCounts[student.CurrentSubject] = 1;
                        }
                    }
                }

                return subjectCounts;
            }
        }
    }
}
