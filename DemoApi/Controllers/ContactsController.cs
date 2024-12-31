using Microsoft.AspNetCore.Mvc;
using DataAccessLibrary;
using Microsoft.Azure.Cosmos.Serialization.HybridRow;
using DataAccessNoSQLLibrary;
using DataAccessNoSQLLibrary.Models;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : Controller
    {
        private static MongoDbDataAccess _db;
        private static readonly string _tableName = "Contacts";
        private readonly IConfiguration _config;

        public ContactsController(IConfiguration config)
        {
            _config = config;
            _db = new MongoDbDataAccess("MongoContactsDb", GetConnectionString());
        }

        [HttpGet]
        public List<ContactModel> GetAll()
        {
            return GetAllContacts();
        }

        [HttpPost]
        public void InsertRecord(ContactModel contact)
        {
            CreateContact(contact);
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

        private static List<ContactModel> GetAllContacts()
        {
            var contacts = _db.LoadRecords<ContactModel>(_tableName);
            return contacts;
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
