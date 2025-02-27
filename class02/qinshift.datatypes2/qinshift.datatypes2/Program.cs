
#region Variables and Data Types



using System;

int testVariable = 0;
int number = 5;
int studentCount = 19;


int veryBigNumber1 = -2147483648;

long veryBigNumber2 = -214748364823;

short buildingFloors = 10;




Console.WriteLine(testVariable);

Console.WriteLine(number);
Console.WriteLine(studentCount);
Console.WriteLine(veryBigNumber2);
Console.WriteLine(buildingFloors);




double price = 19.4;
decimal tax = 1.4m;
float weight = 3.4f;

char specialCharacter = '!';

string fName = "Robert";
string lName = "Ristovski";

bool isWorking = true;
bool isStudent = false;

Console.WriteLine(price);
Console.WriteLine(tax);
Console.WriteLine(weight);
Console.WriteLine(specialCharacter);
Console.WriteLine(fName);
Console.WriteLine(lName);
Console.WriteLine(isWorking);
Console.WriteLine(isStudent);
#endregion


#region Operators

int a = 10;
int b = 15;
double d = 15;


int sum = a + b;
int difference = a - b;
int product = a * b;
double division = a / d;
int modulus = a % b;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(product);
Console.WriteLine(division);
Console.WriteLine(modulus);

bool isGreater = a > b;
Console.WriteLine(isGreater);

string academyName = "SEDC";
string courseName = "QA Automation";
string fullCourseName = academyName + " " + courseName;
Console.WriteLine(fullCourseName);


#endregion

#region Default Values

int someNumber = default;
string someText = default;
bool someBoolean = default;
double someDouble = default;

Console.WriteLine(someNumber);
Console.WriteLine(someText);
Console.WriteLine(someBoolean);
Console.WriteLine(someDouble);

//Console.WriteLine(typeof(someText));





#endregion


#region exarise 1
double firstNumber = 255;
double secondNumber = 10;

double divide = firstNumber / secondNumber;

int thirdNumber = 100;
int fourthNumber = 20;

int divideInt = fourthNumber / thirdNumber;

Console.WriteLine(divide);
Console.WriteLine(divideInt);


#endregion

#region exarise 2

string firstName = "Robert";
string lastName = "Ristovski";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

string number1 = "9";
string number2 = "3";

string fullNumber = number1 + number2;
Console.WriteLine(fullNumber);

string fullInteString = firstNumber + firstName;
Console.WriteLine(fullInteString);
#endregion

#region exarise 3

int credits = 102;
int sms = 5;
int totalSms = credits / sms;
Console.WriteLine(totalSms);


#endregion


