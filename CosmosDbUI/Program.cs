using DataAccessLibrary;
using DataAccessNoSQLLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace CosmosDbUI
{
    class Program
    {
        private static CosmosDBDataAccess _db;
        static void Main(string[] args)
        {
            var c = GetCosmosDbConfiguration();
            _db = new CosmosDBDataAccess(c.endpointUrl, c.primaryKey, c.databaseName, c.containerName);

            Console.WriteLine("Done processing MongoDb");
            Console.ReadLine();
        }

        private static void RemoveContact(ContactModel contact)
        {
        }

        public static void RemovePhoneNumberFromUser(ContactModel user, string phoneNumber)
        {

        }

        private static void GetAllContacts()
        {

        }

        private static void UpdateContact(ContactModel contact)
        {

        }

        private static void GetContactById(string id)
        {

        }

        private static (string endpointUrl, string primaryKey, string databaseName, string containerName) GetCosmosDbConfiguration()
        {
            (string endpointUrl, string primaryKey, string databaseName, string containerName) output = (null, null, null, null);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder?.Build();

            output.endpointUrl = config?.GetValue<string>("CosmosDB:EndpointUrl") ?? string.Empty;
            output.primaryKey = config?.GetValue<string>("CosmosDB:PrimaryKey") ?? string.Empty;
            output.databaseName = config?.GetValue<string>("CosmosDB:DatabaseName") ?? string.Empty;
            output.containerName = config?.GetValue<string>("CosmosDB:ContainerName") ?? string.Empty;
            return output;
        }

        private static void CreateContact(ContactModel contact)
        {

        }
    }
}
