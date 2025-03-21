using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstname, string lastname, double salary) : base(firstname, lastname, RoleEnum.Manager, salary)
        {
            Bonus = 0;
        }
        public void AddBonus(double number)
        {
            Bonus += number;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
