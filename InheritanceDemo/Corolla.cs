using System;

namespace InheritanceDemo
{
    public class Corolla : Car
    {
        public Corolla()
        {
            Make = "Toyota";
            Model = "Corolla";
            NumberOfDoors = 4;
            NumberOfWheels = 4;
            Year = 2018;
        }

        public void Drive()
        {
            Console.WriteLine("Driving Corolla...");
        }
    }
}
