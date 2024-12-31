using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateContact();

            //ReadAll();
            //ReadById(1);
            Console.WriteLine("Done Procesing");
            Console.ReadLine();
        }

        private static void CreateContact()
        {

            var c = new Contact
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var email = new Email
            {
                EmailAddress = "1@2.com"
            };
            c.EmailAddresses.Add(email);

            email = new Email
            {
                EmailAddress = "2@2.com"
            };
            c.EmailAddresses.Add(email);
            var number = new Phone
            {
                PhoneNumber = "123-456-7890"
            };
            c.PhoneNumbers.Add(number);

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .ToList();

                foreach (var c in records)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                    foreach (var e in c.EmailAddresses)
                    {
                        Console.WriteLine($"\t{e.EmailAddress}");
                    }
                    foreach (var p in c.PhoneNumbers)
                    {
                        Console.WriteLine($"\t{p.PhoneNumber}");
                    }
                }
            }
        }

        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var c = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .FirstOrDefault(c => c.Id == id);

                if (c != null)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                    foreach (var e in c.EmailAddresses)
                    {
                        Console.WriteLine($"\t{e.EmailAddress}");
                    }
                    foreach (var p in c.PhoneNumbers)
                    {
                        Console.WriteLine($"\t{p.PhoneNumber}");
                    }
                }
            }
        }
    }
}
