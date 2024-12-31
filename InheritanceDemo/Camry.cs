using System;

namespace InheritanceDemo
{
    public class Camry : Car
    {
        public Camry()
        {
            Make = "Toyota";
            Model = "Camry";
            NumberOfDoors = 4;
            NumberOfWheels = 4;
            Year = 2018;
        }

        public void Drive()
        {
            Console.WriteLine("Driving Camry...");
        }
    }
}
