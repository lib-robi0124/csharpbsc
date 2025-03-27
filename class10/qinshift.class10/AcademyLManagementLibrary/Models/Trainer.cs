using AcademyLManagementDomain.Enums;

namespace AcademyLManagementDomain.Models
{
    public class Trainer : User
    {
        public Trainer(string firstname, string lastname, string username, string password, int age) : base(firstname, lastname, username, password, age)
        {
            Role = Role.Trainer;

        }
        public Trainer(string username, string password) : base(username, password) { Role = Role.Trainer; }
}
}
