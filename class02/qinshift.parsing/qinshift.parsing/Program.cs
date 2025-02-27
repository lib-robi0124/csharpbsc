

//string fullName = Console.ReadLine();

//Console.WriteLine(fullName);



#region Parsed Data
int userNumber = int.Parse(Console.ReadLine());
double userDecimalNumber = double.Parse(Console.ReadLine());

Console.WriteLine(userNumber);
Console.WriteLine(userDecimalNumber);


#endregion

#region Convert.To..() Methods

int userInput = Convert.ToInt32(Console.ReadLine());
double userDecimal = Convert.ToDouble(Console.ReadLine());
bool userBoolInput = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine(userInput);
Console.WriteLine(userDecimal);
Console.WriteLine(userBoolInput);



#endregion

#region TryParse Methods

bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber);
bool userDecimal1 = double.TryParse(Console.ReadLine(), out double parsedDecimal);
bool userBoolInput1 = bool.TryParse(Console.ReadLine(), out bool parsedBool);

Console.WriteLine(userInput1);
Console.WriteLine(userDecimal1);
Console.WriteLine(userBoolInput1);



#endregion