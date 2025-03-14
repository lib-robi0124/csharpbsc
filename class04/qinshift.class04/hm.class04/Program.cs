

//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

#region AgeCalculator
Console.WriteLine("Please enter your birthday: (format: dd.MM.yyyy)");
DateTime birthdayDate = DateTime.Parse(Console.ReadLine());
int birthYear = birthdayDate.Year;
Console.WriteLine($"Birthday by date only: {birthdayDate:dd.MM.yyyy}");
Console.WriteLine($"Input year: {birthYear}");

DateTime currentDateAndTime = DateTime.Now;
int yearToday = currentDateAndTime.Year;
Console.WriteLine($"Today's year is: {yearToday}");

// Calculate age
int age = yearToday - birthYear;

// Check if birthday has passed this year
DateTime birthdayThisYear = new DateTime(yearToday, birthdayDate.Month, birthdayDate.Day);

if (birthdayThisYear > currentDateAndTime)
{
    age--; // If birthday hasn't occurred yet this year, subtract 1
}

if (birthdayThisYear == currentDateAndTime.Date)
{
    Console.WriteLine("Happy Birthday!");
}

Console.WriteLine($"You are {age} years old");

#endregion


Console.ReadLine();