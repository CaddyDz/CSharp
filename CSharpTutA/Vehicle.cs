using System;

namespace CSharpTutA
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        // Constructor
        public Vehicle(string brand = "No Brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} moves forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
