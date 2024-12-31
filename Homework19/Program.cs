using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(5, 10));
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine("Shape {0}: {1}, Area: {2}", i + 1, shapes[i].ToString(), shapes[i].Area());
                Console.WriteLine("Shape {0}: {1}, Perimeter: {2}", i + 1, shapes[i].ToString(), shapes[i].Perimeter());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
