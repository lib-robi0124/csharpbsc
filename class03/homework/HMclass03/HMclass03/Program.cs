
#region Task1 == SumOfEven

bool userinput;
int i = 0;
int sum = 0;
int[] numbers = new int[6];
do
{
    Console.Write("Enter number: ");
    string input = Console.ReadLine();
    userinput = int.TryParse(input, out int parsedNumber);
    if (userinput)
    {
        numbers[i] = parsedNumber;
        i++;
        if (parsedNumber % 2 == 0)
        {
            sum += parsedNumber;
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Try again!");
    }
} while (i < 6);
for (i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"integer no.{i + 1} is {numbers[i]}");
}
Console.WriteLine($"Sum of even numbers is {sum}");



#endregion

#region Task2 == StudentGroup
string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Janko", "Ranko", "Mile", "Pero", "Zile" };
Console.WriteLine("Enter student group: (e.g. 1 for G1 or 2 for G2)");
int group = int.Parse(Console.ReadLine());
if (group == 1)
{
    Console.WriteLine("The students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (group == 2)
{
    Console.WriteLine("The students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input! Try again!");
}

#endregion

#region Task3 
string[] names = [];
string continueExecute = string.Empty;
while (continueExecute.ToUpper() != "N")
{
    Console.WriteLine("Hello there!");
    Console.WriteLine("Enter a name:");
    string name = Console.ReadLine();
    names[names.Length] = name;
    Console.WriteLine("Do you want to continue? Y / N");
    continueExecute = Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("You entered the following names:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

#endregion

Console.ReadLine();