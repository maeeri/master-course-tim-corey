using DataAccessNoSQLLibrary;
using DataAccessNoSQLLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;

namespace MongoDbUI
{
    static class Program
    {
        private static MongoDbDataAccess _db;
        private static readonly string _tableName = "Contacts";

        static void Main(string[] args)
        {
            _db = new MongoDbDataAccess("MongoContactsDb", GetConnectionString());

            //ContactModel user = new ContactModel
            //{
            //    FirstName = "Tina",
            //    LastName = "Smith"
            //};
            //user.EmailAddresses.Add(new EmailAddressModel
            //{
            //    EmailAddress = "tina.smith@gmai.com"
            //});
            //user.PhoneNumbers.Add(new PhoneNumberModel
            //{
            //    PhoneNumber = "123-456-7890"
            //});
            //user.PhoneNumbers.Add(new PhoneNumberModel
            //{
            //    PhoneNumber = "133-456-8888"
            //});
            //CreateContact(user);
            //{29150a54-8e37-425c-a3c4-6e043bd49741}
            //3657db60-47de-4f7b-bd0e-3e05001a7629

            //GetAllContacts();
            //GetContactById("29150a54-8e37-425c-a3c4-6e043bd49741");
            //var user = GetContactById("3657db60-47de-4f7b-bd0e-3e05001a7629");
            //user.FirstName = "Joseph";
            //UpdateContact(user);
            //GetContactById("3657db60-47de-4f7b-bd0e-3e05001a7629");
            //var phonenumber = user.PhoneNumbers[0];
            //RemovePhoneNumberFromUser(user, phonenumber.PhoneNumber);
            //RemoveContact(user);
            Console.WriteLine("Done processing MongoDb");
            Console.ReadLine();
        
        }

        private static MongoDbDataAccess GetDb(MongoDbDataAccess db)
        {
            return db;
        }

        private static void RemoveContact(ContactModel contact)
        {
            _db.DeleteRecord<ContactModel>(_tableName, contact.Id.ToString());
        }

        public static void RemovePhoneNumberFromUser(ContactModel user, string phoneNumber)
        {
            var phoneNumbers = user.PhoneNumbers.Where(p => p.PhoneNumber != phoneNumber).ToList();
            user.PhoneNumbers = phoneNumbers;
            UpdateContact(user);
        }

        private static void GetAllContacts()
        {
            var contacts = _db.LoadRecords<ContactModel>(_tableName);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            }
        }

        private static void UpdateContact(ContactModel contact)
        {
            _db.UpsertRecord(_tableName, contact.Id, contact);
        }

        private static ContactModel GetContactById(string id)
        {
            var contact = _db.LoadRecordById<ContactModel>(_tableName, id);
            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            return contact;
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder?.Build();
            output = config!.GetConnectionString(connectionStringName)!;

            return output ?? "";
        }

        private static void CreateContact(ContactModel contact)
        {
            _db.InsertRecord(_tableName, contact);
        }
    }
}
