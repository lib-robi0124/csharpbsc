using AcademyLManagementDomain.Enums;

namespace AcademyLManagementDomain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }   
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


        public User(string username, string password) 
        {
            Username = username;
            Password = password;
        }
        public User(string firstname, string lastname, string username, string password, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Username = username;
            Password = password;
            Age = age;
        }

        public string GetFullName ()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
