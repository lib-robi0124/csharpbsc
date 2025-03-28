using AcademyLManagementDomain;
using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;

namespace AcademyManagementServices.UserServices
{
    public class StudentService
    {
        private DataAccess _dataAccess { get; set; }
        public StudentService()
        {
            _dataAccess = new DataAccess();
        }

        //login
        public Student StudentLogin(string username, string password)
        {
            Student studentFromDb = _dataAccess.GetStudent(username, password);
            if (studentFromDb == null)
            {
                throw new Exception("Invalid credentials");
            }
            return studentFromDb;
        }
        public List<string> GetStudentUsers(Role role, Student loggedStudent)
        {
            return _dataAccess.GetUsernames(role, loggedStudent);
        }
    }
}
