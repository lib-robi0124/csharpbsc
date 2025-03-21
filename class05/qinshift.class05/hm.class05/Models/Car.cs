using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm.class05.Models
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }
      
        public Car(string model, int speed, string driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }
        


    }
}
