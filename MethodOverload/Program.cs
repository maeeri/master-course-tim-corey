using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Person = new PersonModel();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            this.email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("gmail.com", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }


        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("gmail.com", firstInitialMethod);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod)
            {
                email = $"{FirstName[0] }.{ LastName }@{ domain }";
            }
            else
            {
                email = $"{ FirstName }.{ LastName }@{ domain }";
            }
        }
    }
}
