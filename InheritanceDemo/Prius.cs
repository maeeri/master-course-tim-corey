using System;

namespace InheritanceDemo
{
    public class Prius : Car
    {
        public Prius()
        {
            Make = "Toyota";
            Model = "Prius";
            NumberOfDoors = 4;
            NumberOfWheels = 4;
            Year = 2018;
        }

        public void Drive()
        {
            Console.WriteLine("Driving Prius...");
        }
    }
}
