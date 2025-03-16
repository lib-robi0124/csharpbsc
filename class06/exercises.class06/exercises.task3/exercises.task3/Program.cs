using exercises.task3.Models;
using System.Globalization;


#region ATM.class06.Task3
Customer bob = new Customer("Bob", "Bobsky", "1234-1234-1234-1234", 4325, 650);


Console.WriteLine("Welcome to the ATM app:");
Console.WriteLine("Please enter your card number:");
string card = Console.ReadLine();
if (card != bob.Card)
{
    Console.WriteLine("Invalid card number. Exiting...");
    return;
}
Console.WriteLine("Please enter your pin:");
int pin = int.Parse(Console.ReadLine()); //must enter 4 digit pin
if (pin != bob.Pin)
{
    Console.WriteLine("Invalid pin. Exit or enter again...");
    return;
}
Console.WriteLine("Please make a chice from 1 to 4");
Console.WriteLine("1. Balance checking");
Console.WriteLine("2. Cash withdrawal");
Console.WriteLine("3. Cash deposition");
Console.WriteLine("4. Exit");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        bob.CardBalance();
        break;
    case "2":
        Console.WriteLine("How much would you like to withdraw?");
        string withdraw = Console.ReadLine();
        bob.CashWithdrawal(withdraw);
        break;
    case "3":
        Console.WriteLine("How much would you like to deposit?");
        string deposit = Console.ReadLine();
        bob.CashDeposit(deposit);
        break;
    case "4":
        return;
    default:
        Console.WriteLine("Invalid choice. Try again.");
        break;
}


#endregion

Console.ReadLine();
