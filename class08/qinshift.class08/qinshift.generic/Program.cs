
using qinshift.generic.Models;
static void PrintUsers(List<User> users)
{
    foreach (User user in users)
    {
        Console.WriteLine($"{user.FirstName}  {user.LastName}");
    }

}


#region List
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
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

List<User> users = new List<User>
{
    new User { FirstName = "Martin", LastName = "Panovski"},
    new User { FirstName = "Frosina", LastName = "Stamenkovska"},
    new User { FirstName = "Angel", LastName = "Ivanovski"},
};

PrintUsers(users);



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

};


PrintTodos(todos);

students.ContainsKey(5);
students.ContainsValue("Martin");

students.Remove(2);

#endregion

#region Queue

Console.WriteLine("Queue");
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);


queue.Dequeue();
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
