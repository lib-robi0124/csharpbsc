Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("== strings ==");
Console.ResetColor();

#region String Concatenation
// normal strings
string firstName = "John";
string lastName = "Doe";

// string concatenation
// 1) using "+" operator
string hello1 = "Hello " + firstName + " " + lastName;
Console.WriteLine(hello1);

// 2) *using String Interpolation*
string hello2 = $"Hello {firstName} {lastName}";
Console.WriteLine(hello2);

// 3) using String.Format
string hello3 = String.Format("Hello {0} {1}", firstName, lastName);
Console.WriteLine(hello3);

// 4) using StringBuilder (only for info, will be explained in detail further on..)
//StringBuilder sb = new StringBuilder();
//sb.Append("Hello ");
//sb.Append(firstName);
//sb.Append(" ");
//sb.Append(lastName);
//string hello4 = sb.ToString();
//Console.WriteLine(hello4);

// 5) using String.Concat
string hello5 = String.Concat("Hello ", firstName, " ", lastName);
Console.WriteLine(hello5);


#endregion


#region String Formatting

// 1) Currency
string currency = string.Format("Total: {0:C}", 123.45);
Console.WriteLine(currency);

// *Percent formatting*
string percent = string.Format("Percent: {0:P}", 0.5);
Console.WriteLine(percent);
Console.WriteLine(string.Format("Percent: {0:P0}", 0.5));

// *Custom formatting*
string customPhoneNumberFormat = string.Format("Phone: {0:0##-###-###}", 070358459);
Console.WriteLine(customPhoneNumberFormat);

int number = 123456789;
string customNumberFormat = string.Format("Number format: {0:#,##0}", number);
Console.WriteLine(customNumberFormat);

// *Alignment text formating*
string customAlignment = string.Format("| {0,10} | {1,20} |", "Id", "Order");
Console.WriteLine(customAlignment);

#endregion

#region escaping reserved characters
// Reserved Characters in C#: \, \n, \t, \uXXXX, ", \a, etc...
//string escape1 = "Check your c:\ drive"; // error
//string escape2 = "We will have "fair" elections"; // error
//string escape3 = "The \n sign means: new line";
//Console.WriteLine(escape3);

// 1) Escaping with "\" (backslash) 
string escape1 = "Check your c:\\ drive";
string escape2 = "We will have \"fair\" elections";
string escape3 = "The \\n sign means: new line";

// 2) Escaping a whole string with @
escape1 = @"Check your c:\ drive";
escape2 = @"We will have ""fair"" elections";
escape3 = @"The \n sign means: new line";
Console.WriteLine(escape1);
Console.WriteLine(escape2);
Console.WriteLine(escape3);


#endregion

#region using ToString

Console.WriteLine("\n\n============== ToString() ==============\n");
int someNumber = 123456789;
bool isTrue = false;

// => Convert other datatypes to string
string someNumberString = someNumber.ToString();
string isTrueString = isTrue.ToString();

Console.WriteLine($"this is someNumberString {someNumberString}");
Console.WriteLine($"this is isTrueString {isTrueString}");

// => Using ToString for formatting 
string formatedString = someNumber.ToString("#,##0");
Console.WriteLine($"this is formatedString {formatedString}");


#endregion

#region String Methods
string ourString = "   We are learning C#. It is FUN and EASY. Okay maybe just FUN.    ";
Console.WriteLine(ourString);

// 1) upper and lower case
Console.WriteLine(ourString.ToUpper());
Console.WriteLine(ourString.ToLower());

// 2) Trim
// => It trims the white spaces at the front and back of the string
Console.WriteLine(ourString.Trim());

// 3) Length (property)
Console.WriteLine(ourString.Length);

// 4) Split
// => Splits the string and makes an array of strings (splits on specified character/delimeter )
string[] splittedString = ourString.Split('.');
Console.WriteLine("SPLITTED");
Console.WriteLine(splittedString[0]);
Console.WriteLine(splittedString[1]);
Console.WriteLine(splittedString[2]);
Console.WriteLine(splittedString[3]);

// 5) join
// => Concatenates the members of a collection (array), using the specified separator between each member
string joinedString = string.Join(".(PERIOD)", splittedString);
Console.WriteLine(joinedString);




#endregion


Console.ReadLine();
