using classesandobjectoveview.Models;
using System.Text.RegularExpressions;


Academy webDevAcademy = new Academy("web development", "full stack web dev academy");

Group g1 = new Group("G1", 20, "Palmyra");
Group g2 = new Group("G2", 15, "Petra");
Group g3 = new Group("G1", 18, "Annie");
Group g4 = new Group("G1", 10, "Babylon");


webDevAcademy.Groups = new Group[] { g1, g2, g3, g4 };

Student martin = new Student("martin Panovski", 31, g2);
Student frose = new Student("Frosina Stamenkovska", 30, g3);


Console.WriteLine($"the student {martin.FullName} is student on the {martin.Group.Name} group");
Console.WriteLine($"the student {frose.FullName} is student on the {frose.Group.Name} group");


Console.ReadLine();
