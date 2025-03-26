
using qinshift.generic.Models;
static void PrintUsers(List<User> users)
{
    foreach (User user in users)
    {
        Console.WriteLine($"{user.FirstName}  {user.LastName}");
    }

}


#region List
// Declaration and initialization of array 
string[] namesArr = new string[1] { "Martin" };

// Declaration and initialization of List
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(-33);
numbers.Add(345);

List<string> names = new List<string>() { "Martin", "Ana", "Frose", "Angel"};
names.Add("Robert");
names.Add("Marija");

List<bool> data = [true, false, true, false];

foreach (string name in names)
{
    Console.WriteLine(name);
}

for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
// List of objects from class , User
List<User> users = new List<User>
//{
//    new User { FirstName = "Martin", LastName = "Panovski"},
//    new User { FirstName = "Frosina", LastName = "Stamenkovska"},
//    new User { FirstName = "Angel", LastName = "Ivanovski"},
//};

// other short way to create list of objects
{
    new() { FirstName = "Martin", LastName = "Panovski"},
    new() { FirstName = "Frosina", LastName = "Stamenkovska"},
    new() { FirstName = "Angel", LastName = "Ivanovski"}
};

PrintUsers(users);
users.RemoveAt(2);
users.Add(new () { FirstName = "Sandra", LastName = "Stojanovska" });
Console.WriteLine("Users after remove-add user");
PrintUsers(users);

names.Remove("Martin");
names.RemoveAt(4);
Console.WriteLine("List names after remove item");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Add multiple items in an existing collection
names.AddRange(new List<string> { "Jane", "Dejan", "Viktor", "David" });
Console.WriteLine("List names after add of multiple items:");
foreach (string name in names)
{
    Console.WriteLine(name);
}
#endregion


#region Dictionary

static void PrintDictionary(Dictionary<int, string> students)
{
    foreach(var student in students)
    {
        Console.WriteLine($"{student.Key} {student.Value}");
    }
};

static void PrintTodos(Dictionary<string, bool> todos)
{
    foreach (var todo in todos)
    {
        Console.WriteLine($"{todo.Key} {(todo.Value ? "Done" : "Todo")}");
    }
}

Dictionary<int, string> students = new Dictionary<int, string>()
{
    { 1, "Martin" },
    {2, "Frose" },
    {3, "Ana" },
};

students.Add(4, "Angel");
students.Add(5, "Sandra");


PrintDictionary(students);

Dictionary<string, bool> todos = new Dictionary<string, bool>()
{
    {"Get my dog foa a walk", false},
    {"Write homework", true},
    {"Buy some milk", true }

};

PrintTodos(todos);

students.ContainsKey(3);
students.ContainsValue("Martin");

students.Remove(2);
Console.WriteLine("Students after remove of item");
PrintDictionary(students);

students.TryGetValue(2, out string studentName);
Console.WriteLine($"The student with key 2 is: {studentName}");
#endregion

#region Queue

Console.WriteLine("Queue");
Queue<int> queue = new Queue<int>();
// Add items in the queue
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

// Remove item from the queue
// removes the first item in the queue
int deletedValues = queue.Dequeue();
Console.WriteLine($"The deleted value is: {deletedValues}");
Console.WriteLine("== queue items ==");
foreach (var item in queue)
{
    Console.WriteLine(item);
};

Console.WriteLine($"the item in the queue is: {queue.Peek()}");
#endregion


#region Stack

Stack<string> words = new Stack<string>();
words.Push("I");
words.Push("am");
words.Push("learning");
words.Push("C#");
words.Push("language");

Console.WriteLine("Stack..");
foreach (var item in words)
    { Console.WriteLine(item); };

words.Pop();
Console.WriteLine("== Stack after pop ==");
foreach (var item in words)
{ Console.WriteLine(item); }
#endregion


#region LINQ language INtegrated Queries

List<Dog> dogs = new List<Dog>
{
    new Dog { Name = "Sparky", Color = "White", Age = 5},
    new Dog { Name = "Butch", Color = "Brown", Age = 3 },
    new Dog { Name = "Ada", Color = "White", Age = 4},
    new Dog { Name = "Lucy", Color = "Black", Age = 6},
    new Dog { Name = "Blacky", Color = "Black-White", Age = 1},

};


#endregion


Console.ReadLine();
