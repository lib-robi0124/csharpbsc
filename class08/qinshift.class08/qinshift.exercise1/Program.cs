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
    Console.WriteLine($"{namephone} has mob.no.: {phonebook[namephone]}");
    return;
}
else
{
    Console.WriteLine("no such contact");
}





#endregion


Console.ReadLine();
