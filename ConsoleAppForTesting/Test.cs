using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTesting
{
    internal class Test
    {
        public static void WriteHello()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Press any key to continue");
            var s = Console.ReadKey();
            Console.WriteLine("Goodbye");
            Task.Delay(1000).Wait();
            Console.WriteLine(s.KeyChar);
        }

    }
}
