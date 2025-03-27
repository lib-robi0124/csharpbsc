using AcademyLManagementDomain.Enums;


namespace AcademyLManagementDomain.Models
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }
        public Dictionary<string, int> SubjectGrade { get; set; }

        public Student(string firstname, string lastname, string username, string password, int age) : base(firstname, lastname, username, password, age)
        {
            Role = Role.Student;

        }
        public Student(string username, string password) : base(username, password) { Role = Role.Student; }
    }
}
