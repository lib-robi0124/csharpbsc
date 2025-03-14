using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3.Models
{
  
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Academy: {Academy}, Group: {Group}");
        }

    }
}
