using Infra.Entity;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class PedidoRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<PedidoEntity> _collection;

        public PedidoRepository(string connectionString, string dataBase)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("vendas");
            _collection = _database.GetCollection<PedidoEntity>("pedido");
        }

        public async Task Insert(PedidoEntity user)
        {
            await _collection.InsertOneAsync(user);
        }

        public async Task<bool> Update(string filterName, object filterValue, string udateFieldName, object updateFieldValue)
        {
            var filter = Builders<PedidoEntity>.Filter.Eq(filterName, filterValue);
            var update = Builders<PedidoEntity>.Update.Set(udateFieldName, updateFieldValue);

            var result = await _collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }

        public async Task<bool> Update(string filterName, string filterValue, PedidoEntity model)
        {
            var filter = Builders<PedidoEntity>.Filter.Eq(filterName, filterValue);

            var result = await _collection.ReplaceOneAsync(filter, model);

            return result.ModifiedCount != 0;
        }

        public async Task<List<PedidoEntity>> GetAll()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<PedidoEntity> GetByField(string fieldName, string fieldValue)
        {
            var filter = Builders<PedidoEntity>.Filter.Eq(fieldName, fieldValue);
            var result = await _collection.Find(filter).FirstOrDefaultAsync();

            return result;
        }

        public async void DeleteByField(string fieldName, string fieldValue)
        {
            var filter = Builders<PedidoEntity>.Filter.Eq(fieldName, fieldValue);
            await _collection.DeleteOneAsync(filter);
        }
    }
}