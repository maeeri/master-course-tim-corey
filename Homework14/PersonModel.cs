using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; }

        public PersonModel(string firstName, string lastName, AddressModel address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\n{Address}";
        }
    }
}
