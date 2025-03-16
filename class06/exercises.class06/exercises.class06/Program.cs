using exercises.class06.Models;

#region Task1


//string continueExecute = string.Empty;
//while (continueExecute.ToLower() != "n")
//{
//    Console.WriteLine("Please enter a number: ");

//    if (double.TryParse(Console.ReadLine(), out double userInput))
//    {
//        if (userInput > 0)
//        {
//            Console.WriteLine("Positive");
//        }
//        else
//        {
//            Console.WriteLine("Negative");
//        }

//        if (userInput % 1 == 0)
//        {
//            Console.WriteLine("integer");
//            if (userInput % 2 == 0)
//            {
//                Console.WriteLine("Even");
//            }
//            else
//            {
//                Console.WriteLine("Odd");
//            }
//        }
//        else
//        {
//            Console.WriteLine("decimal");
//            userInput *= 10;
//            if (userInput % 2 == 0)
//            {
//                Console.WriteLine("Even");
//            }
//            else
//            {
//                Console.WriteLine("Odd");
//            }
//        }
//    }
//    Console.WriteLine(userInput);
//    Console.WriteLine("Do you want to continue? Y / N");
//    continueExecute = Console.ReadLine();
//    Console.Clear();
//}


//Console.ReadLine();





#endregion

#region Task2

User[] users = new User[]
{
    new User(20975, "robertr", "Sara1234", new string[] { "Hello Robert", "how are you?" }),
    new User(20621, "rtoska", "1234Sara", new string[] { "Hello Toska", "what's up?" }),
    new User(10275, "rsara", "123456", new string[] { "Hello Sara", "where are you?" }),
};

Console.Write("Enter your Username: ");
string username = Console.ReadLine();
Console.Write("Enter your Password: ");
string password = Console.ReadLine();
Console.WriteLine("Enter your ID:");
//int userInput = Convert.ToInt32(Console.ReadLine());
int userInput;

if (!int.TryParse(Console.ReadLine(), out userInput))
{
    Console.WriteLine("Invalid ID format.");
    return;
}

// Check if the user exists
//User existingUser = users.Find(user => user.ID == userInput);


foreach (var user in users)
{
    if (user != null && user.Username == username && user.Password == password)
    {
        Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
        foreach (var msg in user.Message)
        {
            Console.WriteLine(msg);
        }
        return;
    }
    else if (user.ID != userInput)
    {
        Console.WriteLine("User ID not found. Adding new user...");
        Array.Resize(ref users, users.Length + 1);
        users[users.Length - 1] = new User(userInput, username, password, new string[] { "No messages yet." });
        Console.WriteLine("User added successfully.");
        // Print all users
        Console.WriteLine("\nList of all users:");
        for(int i = 0; i < users.Length; i++)
        {
            Console.WriteLine($"ID: {users[i].ID}, Username: {users[i].Username}, Password: {users[i].Password}");
        }
        
        return;
    }
    
    else
    {
        Console.WriteLine("Invalid username or password!");

    }
}

#region Task3



#endregion









#endregion
