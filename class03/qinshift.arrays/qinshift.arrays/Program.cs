// ==> array type syntax
// array of integers ==> int[]
// array of strings ==> string[]
// array of double ==> double[]

int[] numbers = new int[] { 11, 22, 1, 2, 33, -5, 3 };
//int[] numbers = { 11, 22, 1, 2, 33, -5, 3 };
Console.WriteLine(numbers[0]); // 11
Console.WriteLine(numbers[4]); // 33

string[] students = new string[3];
students[0] = "Bob";
students[1] = "John";
students[2] = "Zvonko";

Console.WriteLine(students[0]);
Console.WriteLine(students[1]);
Console.WriteLine(students[2]);

//students[3] = "Dare"; // error


// ===> length of array

Console.WriteLine("Numbers array lenght is" + numbers.Length);

// ===> sorting

//Array.Sort(numbers);
//Console.WriteLine(numbers[0]);

// ===> reversing an array

//Array.Reverse(numbers);
//Console.WriteLine(numbers[0]);

// ===> search for an element in array
int indexofOne = Array.IndexOf(numbers, 1);
Console.WriteLine($"The index of 1 is {indexofOne}");

int indexofSeven = Array.IndexOf(numbers, 7);
Console.WriteLine($"The index of 1 is {indexofSeven}");



string[] newStudents = new string[3];

newStudents[0] = "Bob";
newStudents[1] = "John";
newStudents[2] = "Zvonko";

//Array.Resize(ref newStudents, 4);
Array.Resize(ref newStudents, newStudents.Length + 1);

newStudents[3] = "Dare";

Console.WriteLine(newStudents[3]);


Console.ReadLine();

    


