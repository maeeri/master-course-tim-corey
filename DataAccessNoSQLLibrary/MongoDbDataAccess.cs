using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace DataAccessNoSQLLibrary
{
    public class MongoDbDataAccess
    {
        private IMongoDatabase _db;
        public MongoDbDataAccess(string dbName, string connectionString)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionString);
            //BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard)); // Set the default GuidRepresentation
            var client = new MongoClient(settings);
            _db = client.GetDatabase(dbName);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = _db.GetCollection<T>(table);
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id.ToString()),
                record,
                new ReplaceOptions { IsUpsert = true });
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, string id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            return collection.Find(filter).FirstOrDefault();
        }

        public void DeleteRecord<T>(string table, string id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }
    }
}
