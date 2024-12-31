using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    internal class AddressModel
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string PostalCode { get; set; }

        public string Country { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{Country}, {City}, {Street}, {House}, {Apartment}, {PostalCode}";
            }
        }
    }
}
