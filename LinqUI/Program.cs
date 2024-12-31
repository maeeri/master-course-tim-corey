using LinqUI.Models;

namespace LinqUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LambdaTests();
            LinqTests();
            Console.WriteLine("Done processing");
            Console.ReadLine();

        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContacts();
            //var results = data.Where(c => c.Addresses.Count > 1).ToList();

            //for (int i = 0; i < results.Count; i++)
            //{
            //    Console.WriteLine($"{results[i].FirstName} {results[i].LastName}");
            //    foreach (var addressId in results[i].Addresses)
            //    {
            //        var address = SampleData.GetAddresses().FirstOrDefault(a => a.Id == addressId);
            //        if (address != null)
            //        {
            //            Console.WriteLine($"\t{address.StreetAddress} {address.City} {address.ZipCode}");
            //        }
            //    }
            //}

            //var otherResults = data.Select(c => $"{c.FirstName} {c.LastName}");
            //foreach (var item in otherResults)
            //{
            //    Console.WriteLine(item);
            //}

            //var results = data.Skip(1).Take(2).ToList();
            //var results = data.OrderByDescending(c => c.LastName).ToList();
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContacts();
            var addresses = SampleData.GetAddresses();
            //var results = (from c in contacts
            //               join a in addresses on c.Id equals a.ContactId
            //               select new {c.FirstName, c.LastName, a.City, a.StreetAddress});

            var results = (from c in contacts
                           select new
                           {
                               c.FirstName,
                               c.LastName,
                               Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)).ToList()
                           });

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Addresses.Count}");
            }

        }
    }
}
