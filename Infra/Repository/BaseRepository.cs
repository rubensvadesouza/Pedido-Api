using Infra.Entity;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class BaseRepository<T>
         where T : IEntity
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<T> _collection;

        public BaseRepository(string connectionString, string dataBase)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(dataBase);
            _collection = _database.GetCollection<T>(typeof(T).Name);
        }

        public async Task Insert(T e)
        {
            await _collection.InsertOneAsync(e);
        }

        public async Task<bool> Update(string filterName, object filterValue, string udateFieldName, object updateFieldValue)
        {
            var filter = Builders<T>.Filter.Eq(filterName, filterValue);
            var update = Builders<T>.Update.Set(udateFieldName, updateFieldValue);

            var result = await _collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }

        public async Task<bool> Update(string filterName, string filterValue, T e)
        {
            var filter = Builders<T>.Filter.Eq(filterName, filterValue);

            var result = await _collection.ReplaceOneAsync(filter, e);

            return result.ModifiedCount != 0;
        }

        public async Task<List<T>> GetAll()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<T> GetByField(string fieldName, string fieldValue)
        {
            var filter = Builders<T>.Filter.Eq(fieldName, fieldValue);
            var result = await _collection.Find(filter).FirstOrDefaultAsync();

            return result;
        }

        public async void DeleteByField(string fieldName, string fieldValue)
        {
            var filter = Builders<T>.Filter.Eq(fieldName, fieldValue);
            await _collection.DeleteOneAsync(filter);
        }
    }
}