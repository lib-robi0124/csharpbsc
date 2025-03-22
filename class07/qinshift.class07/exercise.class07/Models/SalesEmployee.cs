using qinshift.library.Enums;

namespace exercise.class07.Models
{
    public class SalesEmployee : Employee   //Create a SalesPerson class that inherits from Employee
    {
        private double SuccessSaleRevenue { get; set; }  //SuccessSaleRevenue double, private
        public SalesEmployee(string firstname, string lastname, double successsalerevenue) 
            : base(firstname, lastname, RoleEnum.Sales, 1500) //The salary is by default 500 and role is default Sales
        {
            SuccessSaleRevenue = successsalerevenue;
        }
        public void AddSuccessRevenue(double number) //AddSuccessRevenue that will get a number
        {
            SuccessSaleRevenue += number;       //set the SuccessSaleRevenue to that value
        }
        public override double GetSalary()   //Override the GetSalary method to return the value of the salary plus
                                                //bonus that is calculated by the SuccessSaleRevenue.
        {
            if (SuccessSaleRevenue <= 2000)  //If the SuccessSaleRevenue is less than or equal to 2000, the bonus is 500
            {
                return Salary + 500; 
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000) //If the SuccessSaleRevenue is more than 2000 and less than or equal to 5000,
                                                                              //the bonus is 1000
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
