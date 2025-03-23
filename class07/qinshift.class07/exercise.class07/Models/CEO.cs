using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class CEO : Employee
    {
        Employee[] Company { get; set; }    //property Employees (an array of Employees)
        public int Shares { get; set; }        //property Shares (int)
        private double SharePrice { get; set; } //property SharePrice (double)
        public CEO(string firstname, string lastname, double salary, int shares, double shareprice)
            : base(firstname, lastname, RoleEnum.CEO, salary)
        {
            Shares = shares;
            SharePrice = shareprice;
        }
        public void AddSharesPrice(double number)  //a method called AddSharesPrice that will get a number and
        {
            SharePrice += number;           //it will change the SharesPrice
        }
        public void AddEmployee(Employee employee)
        {
            // Add an employee to the company array
            if (Company == null)
            {
                Company = new Employee[5];  // Assuming a max of 5 employees for simplicity
            }
            for (int i = 0; i < Company.Length; i++)
            {
                if (Company[i] == null)
                {
                    Company[i] = employee;
                    break;
                }
            }
        }
        public void PrintEmployees()
        {
            // Print all employees' information
            Console.WriteLine("Employees:");
            foreach (var employee in Company)
            {
                if (employee != null)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}\t//{employee.Role.ToString().ToLower()}");
                }
            }
        }
        public override double GetSalary()  //the method GetSalary to return the Salary + Bonus
        {
            return Salary + (Shares * SharePrice);
        }


    }
}
