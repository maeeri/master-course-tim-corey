using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@email.com"
            };

            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
