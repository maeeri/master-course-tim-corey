using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using System.Runtime.CompilerServices;

namespace SQLServerUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlCrud sql = new SqlCrud(GetConnectionString());
            //ReadAllContacts(sql);
            //ReadContactById(sql, 1);

            //var contacts = ReadAllContacts(sql);

            //foreach (var contact in contacts)
            //{
            //    ReadContactById(sql, contact.Id);
            //}

            //UpdateContact(sql);
            RemovePhoneNumberFromContact(sql, 2, 3);
            Console.WriteLine("Done processing SQL Server");
            Console.ReadLine();
        }

        private static void RemovePhoneNumberFromContact(SqlCrud sql, int contactId, int phoneId)
        {
            sql.RemovePhoneNumber(contactId, phoneId);
        }

        private static void UpdateContact(SqlCrud sql)
        {
            BasicContactModel contact = new BasicContactModel
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            sql.UpdateContactName(contact);
        }

        private static void CreateNewContact(SqlCrud sql)
        {
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel
                {
                    FirstName = "John",
                    LastName = "Smith"
                },
                PhoneNumbers = new List<PhoneNumberModel>
                {
                    new PhoneNumberModel { PhoneNumber = "123-456-7890" },
                    new PhoneNumberModel { PhoneNumber = "987-654-3210" }
                },
                EmailAddresses = new List<EmailAddressModel>
                {
                    new EmailAddressModel { EmailAddress = "nope@email.com" },
                    new EmailAddressModel { Id = 1 }
                }
            };

            sql.CreateContact(user);
        }

        private static List<BasicContactModel> ReadAllContacts(SqlCrud sql)
        {
            var contacts = sql.GetAllContacts();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            }

            return contacts;
        }

        private static void ReadContactById(SqlCrud sql, int id)
        {
            var contact = sql.GetFullContactById(id);

            if (contact != null)
            {
                Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");

                foreach (var phoneNumber in contact.PhoneNumbers)
                {
                    Console.WriteLine($"\t{phoneNumber.Id}: {phoneNumber.PhoneNumber}");
                }

                foreach (var emailAddress in contact.EmailAddresses)
                {
                    Console.WriteLine($"\t{emailAddress.Id}: {emailAddress.EmailAddress}");
                }
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder?.Build();
            output = config!.GetConnectionString(connectionStringName)!;

            return output != null ? output : "";
        }
    }
}
