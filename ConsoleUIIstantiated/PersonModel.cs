using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIIstantiated
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }

        public PersonModel(string firstName, string lastName, string emailAddress = "")
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Console.WriteLine($"{FirstName} {LastName} Instantiated");
        }
    }
}
