using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += i * 5;
            }   
            Console.WriteLine("Total: " + total);
        }
    }
}
