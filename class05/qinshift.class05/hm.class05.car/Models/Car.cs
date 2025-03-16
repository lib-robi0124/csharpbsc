namespace hm.class05.car.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public Car()
        {
        }
        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }
        public string CarInfo()
        {
            return $"The car model is {Model}, the speed is {Speed} and the driver is {Driver.Name}";
        }
        public string Drive()
        {
            return $"{Driver.Name} is driving the car {Model} at the speed of {Speed} km/h";
        }
        public int CalculateSpeed()
        {
            int carSpeed = Driver.Skill * this.Speed;
            return carSpeed;
        }

    }

}
