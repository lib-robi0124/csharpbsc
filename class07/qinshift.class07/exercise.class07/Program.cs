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
Manager manager = new Manager("Petar", "Perovski", 5000, "IT Department");
manager.AddBonus(500);
manager.PrintInfo();

#endregion

#region Contractor
Contractor contractor = new Contractor("Jane", "Smith", 40, 50, manager);

contractor.PrintInfo();
System.Console.WriteLine($"Contractor's responsible department: {contractor.CurrentPosition()} " +
    $"and responsible Manager is {manager.FirstName} {manager.LastName}");
System.Console.WriteLine($"Contractor's calculated salary: {contractor.GetSalary()}");


#endregion

Console.ReadLine();