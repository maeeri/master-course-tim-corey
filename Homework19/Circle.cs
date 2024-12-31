using System;

namespace Homework19
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}
