using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Person person = new Person("John", "Doe", 25, PersonCreated);

            Console.ReadLine();
        }

        public static void PersonCreated(object sender, Person person)
        {
            $"Person created: {person}".WriteSuccess();
        }
    }
}
