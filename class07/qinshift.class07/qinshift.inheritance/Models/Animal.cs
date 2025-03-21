namespace qinshift.inheritance.Models
{
    public class Animal
    {
        public Animal()
        {
         
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Animal(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void Speak()
        {
            Console.WriteLine($"Animal {Name} says hi!");
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Color: {Color}");
        }
    }
}
