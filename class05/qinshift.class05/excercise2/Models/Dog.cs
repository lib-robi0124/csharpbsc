
namespace excercise2.Models
{
    public class Dog
    {
        public string DogName { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog()
        {

        }
        public Dog(string name, string race, string color)
        {
            DogName = name;
            Race = race;
            Color = color;
        }

        public string DogEat()
        {
            return $"{DogName} is now eating!!";
        }
        public string DogPlay()
        {
            return $"{DogName} is now playing!!";
        }
        public string DogChaseTail()
        {
            return $"{DogName} is now chasing its tail!!";
        }

    }
}
