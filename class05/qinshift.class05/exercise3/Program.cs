using exercise3.Models;
using System.ComponentModel.Design;

#region Students

string continueExecute = string.Empty;
while (continueExecute.ToLower() != "n")
{
    Student[] students = new Student[]
       {
            new Student("Toska", "Science Academy", "A1"),
            new Student("Robert", "Math Academy", "B2"),
            new Student("Sara", "Engineering Academy", "C3"),
            new Student("Zivkica", "Arts Academy", "D4"),
            new Student("Ada", "Business Academy", "E5")
       };
   

    Console.WriteLine("Please write a Student name:");
    string studentName = Console.ReadLine();

    bool found = false;
    for (int i = 0; i < students.Length; i++)
    {
        if (students[i].Name == studentName)
        {
            students[i].DisplayInfo();
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine("Student not found");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Students in a list are: {students[i].Name}");
        }
    }
    
    Console.WriteLine("Do you want to continue? Y / N");
    continueExecute = Console.ReadLine();
    Console.Clear();
}


    #endregion

    Console.ReadLine();