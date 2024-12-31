using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIOOP
{
    public class CalculateData
    {
        public static double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }

        public static double Subtract(double x, double y)
        {
            double output = x - y;
            return output;
        }

        public static double Multiply(double x, double y)
        {
            double output = x * y;
            return output;
        }

        public static double Divide(double x, double y)
        {
            double output = x / y;
            return output;
        }

        public static double Modulus(double x, double y)
        {
            double output = x % y;
            return output;
        }

        public static double Power(double x, double y)
        {
            double output = Math.Pow(x, y);
            return output;
        }

        public static double SquareRoot(double x)
        {
            double output = Math.Sqrt(x);
            return output;
        }

        public static double CubeRoot(double x)
        {
            double output = Math.Pow(x, 1.0 / 3.0);
            return output;
        }

        public static double AreaOfCircle(double radius)
        {
            double output = Math.PI * Math.Pow(radius, 2);
            return output;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            double output = length * width;
            return output;
        }

        public static double AreaOfTriangle(double baseLength, double height)
        {
            double output = 0.5 * baseLength * height;
            return output;
        }

        public static double AreaOfSquare(double sideLength)
        {
            double output = Math.Pow(sideLength, 2);
            return output;
        }

        public static double AreaOfParallelogram(double baseLength, double height)
        {
            double output = baseLength * height;
            return output;
        }

        public static double AreaOfTrapezoid(double base1, double base2, double height)
        {
            double output = 0.5 * (base1 + base2) * height;
            return output;
        }

        public static double AreaOfEllipse(double majorAxis, double minorAxis)
        {
            double output = Math.PI * majorAxis * minorAxis;
            return output;
        }

        public static double AreaOfRhombus(double diagonal1, double diagonal2)
        {
            double output = 0.5 * diagonal1 * diagonal2;
            return output;
        }

        public static double AreaOfRegularPolygon(double perimeter, double apothem)
        {
            double output = 0.5 * perimeter * apothem;
            return output;
        }

        public static double AreaOfEquilateralTriangle(double sideLength)
        {
            double output = (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2);
            return output;
        }
    }
}
