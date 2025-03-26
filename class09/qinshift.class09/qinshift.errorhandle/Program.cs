using qinshift.errorhandle.Models;


//#region Exceptions

//Console.WriteLine(" enter a number:");

//try
//{
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine($"the number you entered is number: {number}");
//}
//catch (Exception ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(" wrong input , try again to enter a valid number");
//    //Console.WriteLine(ex.ToString());
//    Console.WriteLine($" ex msg {ex.Message}");
//}
//finally
//{ 
//    Console.ResetColor();
//    Console.WriteLine(" number example finished");
//    Console.ReadLine();
//}

//#endregion


//#region Self throw ex

//Console.WriteLine(" == self throw ex ==");

//Console.WriteLine(" Enter a letter A or B:");

//try
//{
//    string letter = Console.ReadLine().ToLower().Trim();
//    if (letter == "a" || letter == "b")
//    {
//        Console.WriteLine(" super, you have entered A or B");
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        throw new Exception(" That was not letter A or B!");
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//    //Console.WriteLine(ex.InnerException.Message);

//}
//finally
//{
//    Console.ResetColor();
//    Console.WriteLine("pres any key to exit");
//    Console.ReadLine();
//}


//#endregion

//#region Handle spec ex
//try
//{
//    Console.WriteLine(" enter some character!");
//    char char1 = char.Parse(Console.ReadLine());
//    Console.WriteLine($" you entered the character {char1}");

//    int[] numbers = { 1, 2 };
//    //numbers[2] = 3;

//    Console.WriteLine("please enter 2 numbers:");
//    int num1 = int.Parse(Console.ReadLine());
//    int num2 = int.Parse(Console.ReadLine());
//    int divide = num1 / num2;

//}
//catch (FormatException ex)
//{
//    Console.WriteLine(" enter non charater");
//}
//catch(IndexOutOfRangeException ex)
//{
//    Console.WriteLine(" Array out of range..");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//#endregion

#region Exceptions from methods

static void HumanSkill1(Human human)
{
    try
    {
        foreach (var item in human.Skills)
        {
            Console.WriteLine(item.Name);
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine($" catch inside the func {ex.Message}");
    }
}

static void HumanSkill2(Human human)
{
    foreach (var item in human.Skills)
    { Console.WriteLine(item.Name); }
}

Human h1 = new Human() { Name = "Bob"};
HumanSkill1(h1);

try
{
    HumanSkill2(h1);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

#endregion

Console.ReadLine();