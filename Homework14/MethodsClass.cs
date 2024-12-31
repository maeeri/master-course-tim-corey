using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework14;

namespace Homework14
{
    public static class MethodsClass
    {
        public static void PrintPerson(PersonModel person)
        {
            Console.WriteLine(person);
        }

        public static void GetPersonInfo(out string firstName, out string lastName, out string street, out int streetNumber, out string postalCode, out string city)
        {
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter street: ");
            street = Console.ReadLine();
            Console.Write("Enter street number: ");
            streetNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter postal code: ");
            postalCode = Console.ReadLine();
            Console.Write("Enter city: ");
            city = Console.ReadLine();
        }

        public static PersonModel CreatePerson()
        {
            GetPersonInfo(out string firstName, out string lastName, out string street, out int streetNumber, out string postalCode, out string city);
            AddressModel address = new AddressModel(street, streetNumber, postalCode, city);
            return new PersonModel(firstName, lastName, address);
        }
    }
}
