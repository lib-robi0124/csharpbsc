#region exercise 5

int apples = 8; // apples per branch
int basket = 5; // one basket - 5 apples
double fullApples = 0; // full apples per tree
// one tree has 12 branches

Console.WriteLine("Please enter a number of trees");
bool userTreeInput = int.TryParse(Console.ReadLine(), out int parsedTreeNumber);

if (userTreeInput)
{
    if (parsedTreeNumber > 0)
    {
        // calculate full apples per input tree
        fullApples = parsedTreeNumber * 12 * apples;
        // calculate full baskets per input tree
        double fullBasketsPerInputTree = fullApples / basket;

        if (fullBasketsPerInputTree > (int)fullBasketsPerInputTree)
        {
            Console.WriteLine("You need " + ((int)fullBasketsPerInputTree + 1) + " baskets");
        }
        else
        {
            Console.WriteLine("You need " + fullBasketsPerInputTree + "baskets");
        }
    }
    else
    {
        Console.WriteLine("Please enter a number greater than 0");
    }
}
else
{
    Console.WriteLine("Please enter a valid number");

}

#endregion

#region exercise 6
// no request for input , for int or double
int num1 = 5;
int num2 = 10;

if (num1 > num2)
{
    Console.WriteLine("num1 is greater than num2");
}
else if (num1 < num2)
{
    Console.WriteLine("num1 is less than num2");
}
else
{
    Console.WriteLine("num1 is equal to num2");
}
if (num1 % 2 == 0)
{
    Console.WriteLine("num1 is even");
}
else
{
    Console.WriteLine("num1 is odd");
}
if (num2 % 2 == 0)
{
    Console.WriteLine("num2 is even");
}
else
{
    Console.WriteLine("num2 is odd");
}

#endregion

#region exercise 7

// user input for number
Console.WriteLine("Please enter number from 1 to 3");
bool userNumberInput = int.TryParse(Console.ReadLine(), out int parsedNumber);

switch (parsedNumber)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
       default:
        Console.WriteLine("Sorry! Please enter 1 or 2 or 3");
        break;
}


#endregion