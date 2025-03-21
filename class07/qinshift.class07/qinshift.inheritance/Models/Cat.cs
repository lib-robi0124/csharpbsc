namespace qinshift.inheritance.Models
{
   public class Cat : Animal
    {
        public Cat()
        {
        }
        public bool IsLazy { get; set; }
        public Cat(string name, string type, string color, bool islazy) : base(name, type, color)
        {
            IsLazy = islazy;
            Console.WriteLine("Cat contructor executed!");
        }
       
        public override void Speak()
        {
            Console.WriteLine($"Cat {Name} the {IsLazy} says meow!");
        }
    }
      
}
