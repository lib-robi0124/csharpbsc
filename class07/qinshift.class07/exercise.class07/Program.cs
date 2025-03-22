using qinshift.library.Enums;
using exercise.class07.Models;

#region Employee
Employee employee = new Employee("John", "Johnson", RoleEnum.Other, 5000);
employee.PrintInfo();
double salary = employee.GetSalary();
Console.WriteLine($"Fix salary is {salary}");

#endregion

#region SalesEmployee
SalesEmployee salesEmployee = new SalesEmployee("Dean", "Doerty", 2000);
salesEmployee.AddSuccessRevenue(2001);
salesEmployee.PrintInfo();

#endregion

#region Manager
Manager manager = new Manager("Petar", "Perovski", 5000);
manager.AddBonus(500);
manager.PrintInfo();

#endregion

Console.ReadLine();