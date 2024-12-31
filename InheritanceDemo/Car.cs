using System;

namespace InheritanceDemo
{
    public class Car
    {
        public string Make { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void StartCar()
        {
            Console.WriteLine("Starting car...");
        }

        public void StopCar()
        {
            Console.WriteLine("Stopping car...");
        }
    }
}
