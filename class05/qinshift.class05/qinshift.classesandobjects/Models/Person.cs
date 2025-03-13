

namespace qinshift.classesandobjects.Models
{
    public class Person
    {
        public Person()
        {
            SSN = GenerateSSN();
        }

        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            Lastname = lName;
            Age = age;
            SSN = GenerateSSN();
        }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }
        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999);
        }
        public void Talk(string text)
        {
            Console.WriteLine($"the human named {FirstName} is saying {text}!!");
        }
    }
}
