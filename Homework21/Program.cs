using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel
            {
                FirstName = "Jane",
                LastName = "Doe"
            };

            person.PrintInfo().SetDefaultAge().PrintInfo();
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
    }

    public static class ExtensionMethods
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 18;
            return person;
        }

        public static PersonModel PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Full Name: {person.FullName}");
            Console.WriteLine($"Age: {person.Age}");
            return person;
        }
    }
}
