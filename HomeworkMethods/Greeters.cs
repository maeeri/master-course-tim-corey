using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethods
{
    public static class Greeters
    {
        public static void SayWelcome()
        {
            Console.WriteLine("Welcome to this app!");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static string AskForName()
        {
            Console.WriteLine("What is your name?");
            string? input = Console.ReadLine();
            while ( string.IsNullOrEmpty(input) )
            {
                Console.WriteLine("Please enter a valid name.");
                input = Console.ReadLine();
            }
            string output = input;

            return output;
        }

        public static void SayHello(string name)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
