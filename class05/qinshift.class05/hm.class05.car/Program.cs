
using hm.class05.car.Models;



#region hm.class05.car

static void RaceCars(Car car1, Car car2)
{
    int car1Speed = car1.CalculateSpeed();
    int car2Speed = car2.CalculateSpeed();

    Car winner = car1Speed > car2Speed ? car1 : car2;

    Console.WriteLine($"The winner is {winner.Driver.Name} driving a {winner.Model} is faster");
}

Driver[] drivers = new Driver[]
        {
            new Driver("Bob", 4),
            new Driver("Greg", 3),
            new Driver("Jill", 5),
            new Driver("Anne", 5),
        };

Car[] cars = new Car[]
{
            new Car("Hyundai", 220, drivers[0]),
            new Car("Mazda", 180, drivers[1]),
            new Car("Ferrari", 320, drivers[2]),
            new Car("Porsche", 300, drivers[3]),
};

Console.WriteLine("Please choose two cars to race:");
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"Choice {i + 1}) {cars[i].Model}");
}

Console.Write("Enter the number of the first car: ");
int firstCarIndex = int.Parse(Console.ReadLine()) - 1;

Console.Write("Enter the number of the second car: ");
int secondCarIndex = int.Parse(Console.ReadLine()) - 1;

RaceCars(cars[firstCarIndex], cars[secondCarIndex]);

#endregion

Console.ReadLine();

