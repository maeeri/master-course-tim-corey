using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedBreakpoints
{
    internal class MethodClass
    {
        public static void RunsALot()
        {
            long total = 0;
            int test = 0;
            for (int i = -1000; i < 1000; i++)
            {
                total += i;
                try
                {
                    if (i != 0) test = 5 / i;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(total);
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
            Method3();
        }

        public void Method3()
        {
            Console.WriteLine("Method3");
            Method4();
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
            Method5();
        }

        public void Method5()
        {
            Console.WriteLine("Method5");
        }
    }
}
