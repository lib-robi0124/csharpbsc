using AcademyLManagementDomain.Enums;


namespace AcademyLManagementDomain.Models
{
    public class Admin : User
    {
        public Admin(string firstname, string lastname, string username, string password, int age) : base(firstname, lastname, username, password, age)
        {
            Role = Role.Admin;

        }
        public Admin(string username, string password) : base(username, password) { Role = Role.Admin; }

    }
}
