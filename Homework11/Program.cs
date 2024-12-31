using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
            Console.ReadKey();
        }

        static void BadCall()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (i == 5)
                    {
                        throw new Exception("I'm sorry, Dave. I'm afraid I can't do that.");
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("We have an exception", ex);
                }

            }
        }
    }
}
