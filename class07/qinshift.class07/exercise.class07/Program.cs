using qinshift.library.Enums;
using exercise.class07.Models;
using System.Collections.Generic;
using System.Reflection.Metadata;

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

#region CEO
// Create the CEO and employees
CEO ceo = new CEO("Ron", "Ronsky", 1500, 100, 10);

Manager manager1 = new Manager("Bob", "Bobert", 2000, "IT");
Manager manager2 = new Manager("Rick", "Rickert", 2200, "HR");

SalesEmployee salesPerson = new SalesEmployee("Mona", "Monalisa", 3500);
Employee contractor1 = new Employee("Igor", "Igorsky", RoleEnum.Other, 1200);
Employee contractor2 = new Employee("Lea", "Leova", RoleEnum.Other, 1300);

// Add employees to the CEO's company
ceo.AddEmployee(manager1);
ceo.AddEmployee(manager2);
ceo.AddEmployee(salesPerson);
ceo.AddEmployee(contractor1);
ceo.AddEmployee(contractor2);

// Output CEO and employee info
Console.WriteLine("CEO:");
ceo.PrintInfo();
Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");

ceo.PrintEmployees();


#endregion

Console.ReadLine();