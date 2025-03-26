#region Task1

Dictionary<string, int> phonebook = new Dictionary<string, int>()
{
    {"Robert", 070358459 },
    {"Toska", 071237225 },
    {"Sara", 075341411 },
};

Console.WriteLine("Please enter a name from PhoneBook: ");
string namephone = Console.ReadLine();

if(phonebook.ContainsKey(namephone))
{
    Console.WriteLine($"{namephone} has mob.no.: 0{phonebook[namephone]}");
    //return;
}
else
{
    Console.WriteLine("no such contact");
}

#endregion

#region Excercise1
Dictionary<string, string> phonebook2 = new Dictionary<string, string>()
{
    {"070358459", "Robert" },
    {"071237225", "Toska" },
    {"075341411", "Sara" },
    {"070222333", "Martin" },
    {"071333444", "Ana" },
    {"075444555", "Frose" },
    {"070555666", "Martin" },
};
static void SearchByName(Dictionary<string, string> phonebook2, string name)
{
    if(!phonebook2.ContainsValue(name))
    {
        Console.WriteLine("No such contact");
        return;
    }
     Console.WriteLine($"{name} has mob.no.: {phonebook2[name]}");
}
while (true)
{
    Console.WriteLine("Please enter a name from PhoneBook2: ");
    string name = Console.ReadLine();
    SearchByName(phonebook2, name);
    Console.WriteLine("Do you want to search other one? Y or N");
    string answer = Console.ReadLine();
    if (answer.ToLower() == "n")
    {
        break;
    }
    Console.Clear();
}

#endregion

Console.ReadLine();
