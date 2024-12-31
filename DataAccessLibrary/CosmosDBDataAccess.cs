using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CosmosDBDataAccess
    {
        private readonly string _endpointUrl;
        private readonly string _primaryKey;
        private readonly string _databaseName;
        private readonly string _containerName;
        private CosmosClient _cosmosClient;
        private Database _database;
        private Container _container;

        public CosmosDBDataAccess(string endpointUrl, string primaryKey, string databaseName, string containerName)
        {
            this._endpointUrl = endpointUrl;
            this._primaryKey = primaryKey;
            this._databaseName = databaseName;
            this._containerName = containerName;

            _cosmosClient = new CosmosClient(_endpointUrl, _primaryKey);
            _database = _cosmosClient.GetDatabase(_databaseName);
            _container = _database.GetContainer(_containerName);
        }

        public async Task AddItemAsync<T>(T item)
        {
            await _container.CreateItemAsync<T>(item, new PartitionKey(item.GetType().GetProperty("Id").GetValue(item).ToString()));
        }

        public async Task DeleteItemAsync<T>(string id)
        {
            await _container.DeleteItemAsync<T>(id, new PartitionKey(id));
        }

        public async Task<T> GetItemAsync<T>(string id)
        {
            try
            {
                ItemResponse<T> response = await _container.ReadItemAsync<T>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return default;
            }
        }

        public async Task<IEnumerable<T>> GetItemsAsync<T>(string queryString)
        {
            var query = _container.GetItemQueryIterator<T>(new QueryDefinition(queryString));
            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync<T>(string id, T item)
        {
            await _container.UpsertItemAsync<T>(item, new PartitionKey(id));
        }
        
    }
}
