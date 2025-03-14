
using exercise2.Models;

string continueExecute = string.Empty;
while (continueExecute.ToLower() != "n")
{
    Console.WriteLine("enter your Dog Name");
    string dogname = Console.ReadLine();

    Console.WriteLine("enter your Dog Race");
    string dogarace = Console.ReadLine();

    Console.WriteLine("enter your Dog Color");
    string dogcolor = Console.ReadLine();

    Dog dog = new Dog(dogname, dogarace, dogcolor);

    Console.WriteLine($"What do you want {dog.DogName} to do: \n1. Eat \n2. Chase its tail \n3. Play. Select 1, 2, or 3");
    //int userInput = int.Parse(Console.ReadLine());
    if (int.TryParse(Console.ReadLine(), out int userInput))
    {

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
    }
    else
    {
        Console.WriteLine("wrong Input, enter 1 , or 2 or 3");
    }
    Console.WriteLine("Do you want to continue? Y / N");
    continueExecute = Console.ReadLine();
    Console.Clear();
}
