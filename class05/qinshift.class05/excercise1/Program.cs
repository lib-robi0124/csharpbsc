using excercise1.Models;

Console.WriteLine("enter your First Name");
string fName = Console.ReadLine();

Console.WriteLine("enter your Last Name");
string lName = Console.ReadLine();

Console.WriteLine("enter your Age");
int age = Convert.ToInt32(Console.ReadLine());


Human human = new Human(fName, lName, age);
Console.WriteLine(human.GetPersonStats());


Console.ReadLine();
