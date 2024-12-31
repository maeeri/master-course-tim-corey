using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"the value of {x} + {y} = {x+y}");
        }
        public static void AddAll(double[] numbers)
        {
            double sum = numbers.Sum();
            Console.WriteLine($"The sum of all the numbers is {sum}");
        }
    }

    
}
