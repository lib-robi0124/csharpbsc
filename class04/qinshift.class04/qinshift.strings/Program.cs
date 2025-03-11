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


#endregion


#region String Formatting

// 1) Currency
string currency = string.Format("Total: {0:C}", 123.45);
Console.WriteLine(currency);

// *Percent formatting*
string percent = string.Format("Percent: {0:P}", 0.5);
Console.WriteLine(percent);
Console.WriteLine(string.Format("Percent: {0:P0}", 0.5));



#endregion

Console.ReadLine();
