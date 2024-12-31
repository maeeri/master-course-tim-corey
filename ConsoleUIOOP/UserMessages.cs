using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIOOP
{
    public class UserMessages
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ApplicationStartMessage(string name)
        {
            Console.WriteLine("Welcome to the Static Class Demo App");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning, {name}!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon, {name}!");
            }
            else
            {
                Console.WriteLine($"Good Evening, {name}!");
            }
        }
    }
}
