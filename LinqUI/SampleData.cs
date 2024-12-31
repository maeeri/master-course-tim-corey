using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI
{
    public static class SampleData
    {
        public static List<Models.ContactModel> GetContacts()
        {
            var output = new List<Models.ContactModel>
            {
                new Models.ContactModel { Id = 1, FirstName = "John", LastName = "Doe", Addresses = [1,2,3,6] },
                new Models.ContactModel { Id = 2, FirstName = "Jane", LastName = "Smith", Addresses = [4,5] },
                new Models.ContactModel { Id = 3, FirstName = "Bob", LastName = "Johnson", Addresses = [7] }
            };
            return output;
        }

        public static List<Models.AddressModel> GetAddresses()
        {
            var output = new List<Models.AddressModel>
            {
                new() { Id = 1, ContactId = 1, StreetAddress = "123 Elm St", City = "Springfield", ZipCode = "12345" },
                new() { Id = 2, ContactId = 1, StreetAddress = "456 Oak St", City = "Springfield", ZipCode = "12345" },
                new() { Id = 3, ContactId = 1, StreetAddress = "789 Pine St", City = "Springfield", ZipCode = "12345" },
                new() { Id = 4, ContactId = 2, StreetAddress = "101 Elm St", City = "Springfield", ZipCode = "12345" },
                new() { Id = 5, ContactId = 2, StreetAddress = "202 Oak St", City = "Springfield", ZipCode = "12345" },
                new() { Id = 6, ContactId = 1, StreetAddress = "303 Pine St", City = "Springfield", ZipCode = "12345" },
                new() { Id = 7, ContactId = 3, StreetAddress = "404 Maple St", City = "Springfield", ZipCode = "12345" }
            };
            return output;
        }
    }
}
