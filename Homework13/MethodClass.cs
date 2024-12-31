using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class MethodClass
    {
        public static void LoopingMethod()
        {
            for (int i = 1; i < 101; i++)
            {
                try
                {
                    if (i == 73)
                    {
                        throw new Exception("We hit the forbidden number!");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
