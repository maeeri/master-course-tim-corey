using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.YearManufactured = 2018;
            InventoryItem item = new Book();
            Console.ReadLine();
        }
    }
}
