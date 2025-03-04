
// metods

void Greet()
{
    Console.WriteLine("hello from me");
}

// ==> metod execution
Greet();


void GreetStudent(string name)
{
    Console.WriteLine($"hello {name}!");
}

GreetStudent("bob");

// metod to return
string GetFullName(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

string bob = GetFullName("Bob", "Bobski");
Console.WriteLine(bob);


// metod with 3 params
void PrintPersonInfo( string firstName, string lastName, bool isStudent)
{
    if (isStudent)
    {
        Console.WriteLine($"{GetFullName(firstName, lastName)} is programming student");
        return;
    }
}

PrintPersonInfo("Robi", "Ristovski", true);
PrintPersonInfo("Bob", "Bobski", false);
   
