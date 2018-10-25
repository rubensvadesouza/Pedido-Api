using infra.Model;
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
        private IMongoCollection<PedidoModel> _collection;

        public PedidoRepository(string connectionString, string dataBase)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("vendas");
            _collection = _database.GetCollection<PedidoModel>("pedido");
        }

        public async Task Insert(PedidoModel user)
        {
            await _collection.InsertOneAsync(user);
        }

        public async Task<bool> Update(string filterName, string filterValue, string udateFieldName, object updateFieldValue)
        {
            var filter = Builders<PedidoModel>.Filter.Eq(filterName, filterValue);
            var update = Builders<PedidoModel>.Update.Set(udateFieldName, updateFieldValue);

            var result = await _collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }

        public async Task<bool> Update(string filterName, string filterValue, PedidoModel model)
        {
            var filter = Builders<PedidoModel>.Filter.Eq(filterName, filterValue);

            var result = await _collection.ReplaceOneAsync(filter, model);

            return result.ModifiedCount != 0;
        }

        public async Task<List<PedidoModel>> GetAll()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<PedidoModel> GetByField(string fieldName, string fieldValue)
        {
            var filter = Builders<PedidoModel>.Filter.Eq(fieldName, fieldValue);
            var result = await _collection.Find(filter).FirstOrDefaultAsync();

            return result;
        }

        public async void DeleteByField(string fieldName, string fieldValue)
        {
            var filter = Builders<PedidoModel>.Filter.Eq(fieldName, fieldValue);
            await _collection.DeleteOneAsync(filter);
        }
    }
}