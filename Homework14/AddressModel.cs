using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class AddressModel
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public AddressModel(string street, int streetNumber, string postalCode, string city)
        {
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
            City = city;
        }

        public override string ToString()
        {
            return $"{Street} {StreetNumber}\n{PostalCode} {City}";
        }
    }
}
