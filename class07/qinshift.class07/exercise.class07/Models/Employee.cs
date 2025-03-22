
using qinshift.library.Enums;

namespace exercise.class07.Models
{
    
        public class Employee                   //Create a class called Employee with the following properties:
    {
        public string FirstName { get; set; }   //FirstName
        public string LastName { get; set; }    //LastName
        public RoleEnum Role { get; set; }       //Role - Enum ( Sales, Manager, Other )
        protected double Salary { get; set; }   //Salary - protected, double
        public Employee() { }
        public Employee(string firstName, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public virtual double GetSalary()       //GetSalary - returns the salary
        {
            return Salary;
        }
        public void PrintInfo()
        {
            //PrintInfo - Prints FirstName, LastName and Salary
            System.Console.WriteLine($"Employer as role {Role}, is {FirstName} {LastName} and get salary {GetSalary()}");
           
        }
    }
}
