

#region RealCalculator
Console.WriteLine("Calculate operation on 2 numbers");
// inputs from user
Console.WriteLine("Please enter a first number to calculate");
bool userFirstInput = int.TryParse(Console.ReadLine(), out int parsedFirstNumber);
Console.WriteLine("Please enter a second number to calculate");
bool userSecondInput = int.TryParse(Console.ReadLine(), out int parsedSecoundNumber);
Console.WriteLine("Please enter an operation to calculate");
string userOperationInput = Console.ReadLine();


if (userFirstInput)                         // if user first input is a number
{
    if (userSecondInput)                    // if user second input is a number
    {
        switch (userOperationInput)         // switch case for operation
        {
            case "+":
                Console.WriteLine("Sum of those numbers is:" + (parsedFirstNumber + parsedSecoundNumber));
                break;
            case "-":
                Console.WriteLine("Difference between those numbers is:" + (parsedFirstNumber - parsedSecoundNumber));
                break;
            case "*":
                Console.WriteLine("Multiplication of your numbers is:" + (parsedFirstNumber * parsedSecoundNumber));
                break;
            case "/":
                Console.WriteLine("division of your numbers is:" + (parsedFirstNumber / parsedSecoundNumber));
                break;
            default:
                Console.WriteLine("Sorry, no such operation! Please enter + or - or * or / as operation");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a secondnumber as number");
    }
}
else
{
    Console.WriteLine("Please enter a firstnumber as number");

}

#endregion

#region AverageNumber
// inputs of 4 numbers from user
Console.WriteLine("Calculate average from 4 numbers");
Console.WriteLine("Please enter a 1 number");
bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber1);
Console.WriteLine("Please enter a 2 number");
bool userInput2 = int.TryParse(Console.ReadLine(), out int parsedNumber2);
Console.WriteLine("Please enter a 3 number");
bool userInput3 = int.TryParse(Console.ReadLine(), out int parsedNumber3);
Console.WriteLine("Please enter a 4 number");
bool userInput4 = int.TryParse(Console.ReadLine(), out int parsedNumber4);

if (userInput1)
{
    // if user input is a number
    if (userInput2)
    {
        if (userInput3)
        {
            if (userInput4)
            {
                Console.WriteLine("Average of those numbers is:" + ((parsedNumber1 + parsedNumber2 + parsedNumber3 + parsedNumber4) / 4));
            }
            else
            {
                Console.WriteLine("Please enter a number4 as number");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number3 as number");
        }
    }
    else
    {
        Console.WriteLine("Please enter a number2 as number");
    }
}
else
{
    Console.WriteLine("Please enter a number1 as number");
}


#endregion

#region SwapNumbers

// inputs of 2 numbers from user
Console.WriteLine("Swap 2 numbers");
Console.WriteLine("Please enter a first number");
bool userInputOne = int.TryParse(Console.ReadLine(), out int parsedNumberOne);
Console.WriteLine("Please enter a second number");
bool userInputTwo = int.TryParse(Console.ReadLine(), out int parsedNumberTwo);
int swapNumber = 0;

if (userInputOne)
{
    if (userInputTwo)
    {
        swapNumber = parsedNumberOne;
        parsedNumberOne = parsedNumberTwo;
        parsedNumberTwo = swapNumber;
        Console.WriteLine("Your input as first number is" + parsedNumberTwo + " Second number is:" + parsedNumberOne);
        Console.WriteLine(" After Swaping numbers result is:");
        Console.WriteLine("First number is:" + parsedNumberOne + " Second number is:" + parsedNumberTwo);
    }
    else
    {
        Console.WriteLine("Please enter a second number as number");
    }
}
else
{
    Console.WriteLine("Please enter a first number as number");
}



#endregion
