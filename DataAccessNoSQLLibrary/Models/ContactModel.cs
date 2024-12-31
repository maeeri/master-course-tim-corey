using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessNoSQLLibrary.Models
{
    public class ContactModel
    {
        [BsonId(IdGenerator = typeof(GuidGenerator))]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EmailAddressModel> EmailAddresses { get; set; } = [];
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = [];
    }
}
