
//string[] fiveWords = new string[5];
//fiveWords[0] = "Robert";
//fiveWords[1] = "Ristovski";
//fiveWords[2] = "Sara";
//fiveWords[3] = "Toska";
//fiveWords[4] = "Ada";


//double[] fiveDecimal = new double[5];
//fiveDecimal[0] = 0.1;
//fiveDecimal[1] = 0.2;
//fiveDecimal[2] = 0.3;
//fiveDecimal[3] = 0.4;
//fiveDecimal[4] = 0.5;

//string[] fiveChars = new string[5];
//fiveChars[0] = "%";
//fiveChars[1] = "#";
//fiveChars[2] = "@";
//fiveChars[3] = "*";
//fiveChars[4] = ">";

//bool[] fiveBool = new bool[5];
//fiveBool[0] = true;
//fiveBool[1] = false;

//// with array, each holding 2 whole numbers
//int[][] arrayOfArrays = new int[5][]
//{
//    new int[2] {1, 2},
//    new int[2] {3, 4},
//    new int[2] {5, 6},
//    new int[2] {7, 8},
//    new int[2] {9, 10},

//};




//Console.WriteLine(fiveWords[0]);
//Console.WriteLine(fiveDecimal[0]);
//Console.WriteLine(fiveChars[0]);
//Console.WriteLine(fiveBool[0]);


// ===> loops

// ===> while
int counter = 0;
while(counter < 10)
{
    counter++;
    Console.WriteLine(counter);
}


counter = 0;
while(counter < 10)
{
    counter++;
    if (counter % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(counter);
}


while (true)
{
    Console.WriteLine("enter somenthing ( when X to stop)");
    string input = Console.ReadLine();
    if (input.ToUpper() == "X")
    {
        Console.WriteLine("Exit...");
        break;
    }
    Console.WriteLine(input);
};


bool isValid;
do
{
    Console.WriteLine("enter a nunber");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out int parsedNumber);
    if (isValid)
    {
        Console.WriteLine($"the number is {parsedNumber}");
     }
    else
    {
        Console.WriteLine("wrong number input");
    }
} while (!isValid);

// "for" loop
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
};


string[] students = new string[4] { "Ace", "Ada", "Lia", "Koki" };

for ( int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"{i + 1}. {students[i]}");
};


// forEach

foreach(string name in students)
{
    Console.WriteLine(name);
}



Console.ReadLine();


