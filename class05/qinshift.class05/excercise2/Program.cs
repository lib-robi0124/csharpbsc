
using excercise2.Models;

Console.WriteLine("enter your Dog Name");
string dogname = Console.ReadLine();

Console.WriteLine("enter your Dog Race");
string dogarace = Console.ReadLine();

Console.WriteLine("enter your Dog Color");
string dogcolor = Console.ReadLine();

Dog dog = new Dog(dogname, dogarace, dogcolor);

Console.WriteLine("enter 1 (to eat) , or 2 (for tail) or 3 (to play)");
int userInput = int.Parse(Console.ReadLine());

switch (userInput)
{
    case 1:
        Console.WriteLine(dog.DogEat());
        break;
    case 2:
        Console.WriteLine(dog.DogChaseTail());
        break;
    case 3:
        Console.WriteLine(dog.DogPlay());
        break;
    default:
        Console.WriteLine("wrong Input, enter 1 , or 2 or 3");
        break;

}