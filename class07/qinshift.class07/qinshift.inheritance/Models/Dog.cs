namespace qinshift.inheritance.Models
{
    public class Dog : Animal
    {
        public Dog()
        {
        }
        public string Breed { get; set; }
        public Dog(string name, string type, string color, string breed) : base(name, type, color)
        {
            Breed = breed;
            Console.WriteLine("Dog contructor executed!");
        }
        public Dog(string name) : base(name)
        {
            
        }
        public override void Speak()
        {
            Console.WriteLine($"Dog {Name} the {Breed} says woof!");
        }
    }
    
 }
