using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class Contractor : Employee //Add a class called Contractor that inherits from Employee.
    {
        public double WorkingHours { get; set; } //Add a property called WorkingHours of type double.
        public int PayPerHour { get; set; } //Add a property called PayPerHour of type int.
        public Manager Responsible { get; set; } //Add a property called Responsible of type Manager.
        public Contractor(string firstname, string lastname, double workinghours, int payperhour, Manager responsible)
            : base(firstname, lastname, RoleEnum.Manager, 0) //The salary is by default 0 and role is default Other
        {
            WorkingHours = workinghours;
            PayPerHour = payperhour;
            Responsible = responsible;
        }
        // Method to return the department of the responsible manager
        public string CurrentPosition()
        {
            return Responsible?.Department ?? "No manager assigned";
        }
        // Override GetSalary to calculate based on work hours and pay per hour
        public override double GetSalary()
        {
            double calculatedSalary = WorkingHours * PayPerHour;
            Salary = calculatedSalary; // Update the Salary property
            return calculatedSalary;
        }
    }
}
