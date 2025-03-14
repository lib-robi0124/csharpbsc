

namespace exercise1.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string GetPersonStats()
        {
            //Console.WriteLine($"the human named {FirstName} {Lastname} with age {Age} {text}!!");
            return $"{FirstName} {Lastname} - {Age}";
        }
        public Human(string fName, string lName, int age)
        {
            FirstName = fName;
            Lastname = lName;
            Age = age;
        }
    }
}
