using Microsoft.Extensions.Configuration;
using TextDataAccessLibrary;
using TextDataAccessLibrary.Models;

namespace TextFilesUI
{
    internal class Program
    {
        private static IConfiguration _config { get; set; }
        private static string _textFile;
        private static TextFileDataAccess _db = new TextFileDataAccess();
        static void Main(string[] args)
        {
            Init();
            _textFile = _config["TextFile"];

            if (!File.Exists(_textFile) && _textFile != null)
            {
                File.Create(_textFile).Close();
            }
            TextFileDataAccess tf = new TextFileDataAccess();
            ContactModel user = new ContactModel();
            Console.Write("Enter your first name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            user.LastName = Console.ReadLine();
            Console.Write("Enter your email address: ");
            user.EmailAddresses.Add(Console.ReadLine());
            Console.Write("Enter your phone number: ");
            user.PhoneNumbers.Add(Console.ReadLine());
            tf.WriteAllRecords(new List<ContactModel> { user }, _textFile);
            List<ContactModel> contacts = tf.ReadAllRecords(_textFile);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                foreach (var email in contact.EmailAddresses)
                {
                    Console.WriteLine($"Email: {email}");
                }
                foreach (var phone in contact.PhoneNumbers)
                {
                    Console.WriteLine($"Phone: {phone}");
                }
            }
        }

        private static void Init()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _config = builder.Build();
        }

        private static void RemovePhoneNumberFromContact(int contactId, int phoneId)
        {

        }

        private static void UpdateContact()
        {

        }

        private static void CreateNewContact()
        {
            var contacts = _db.ReadAllRecords(_textFile);
            contacts.Add(new ContactModel
            {
                FirstName = "A",
                LastName = "Smith",
                EmailAddresses = new List<string> { "@@" },
                PhoneNumbers = new List<string> { "00" }
            });
            _db.WriteAllRecords(contacts, _textFile);
        }

        private static void ReadAllContacts()
        {
            var contacts = _db.ReadAllRecords(_textFile);

            foreach (var contact in contacts)
            {

            }
        }

    }
}
