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