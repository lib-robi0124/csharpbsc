using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class SalesEmployee : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesEmployee(string firstname, string lastname, double successsalerevenue) : base(firstname, lastname, RoleEnum.Sales, 500)
        {
            SuccessSaleRevenue = successsalerevenue;
        }
        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue += number;
        }
        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500; //we can access the Salary because SalesPerson inherits from Employee
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}
