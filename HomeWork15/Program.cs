using HomeWork15
    ;
using System;


AddressModel address = new AddressModel
{
    City = "Kyiv",
    Street = "Khreshchatyk",
    House = "1",
    Apartment = "1",
    PostalCode = "01001",
    Country = "Ukraine"
};

Console.WriteLine(address.FullAddress);