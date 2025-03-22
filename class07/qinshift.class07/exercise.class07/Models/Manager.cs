using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class Manager : Employee        // class Manager that inherits from Employee
    {
        private double Bonus { get; set; }  //a new property called Bonus - double, private
        public Manager(string firstname, string lastname, double salary) 
            : base(firstname, lastname, RoleEnum.Manager, salary)
        {
            Bonus = 0;              //a constructor that sets all properties except Bonus
        }
        public void AddBonus(double number)  //a method called AddBonus that adds bonus to
                                                //the Bonus property
        {
            Bonus += number;
        }
        public override double GetSalary()  //the method GetSalary to return the Salary + Bonus
        {
            return Salary + Bonus;
        }
    }
}
