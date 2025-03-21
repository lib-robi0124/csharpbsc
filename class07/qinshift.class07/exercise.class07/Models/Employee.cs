using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }
        public Employee() { }
        public Employee(string firstName, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
        public void PrintInfo()
        {
            System.Console.WriteLine($"First Name: {FirstName}");
            System.Console.WriteLine($"Last Name: {LastName}");
            System.Console.WriteLine($"Role: {Role}");
            System.Console.WriteLine($"Salary: {GetSalary()}");
        }
    }
}
