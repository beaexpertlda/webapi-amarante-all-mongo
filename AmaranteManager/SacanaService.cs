using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace webapi_amarante_all.AmaranteManager
{
    public class SacanaService
    {

        private readonly IMongoCollection<Sacana> _book;
        private readonly MongoConfig _settings;
        public SacanaService(IOptions<MongoConfig> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _book = database.GetCollection<Sacana>(_settings.SacanaCollectionName);
        }
        public async Task<List<Sacana>> GetAllAsync()
        {
            return await _book.Find(c => true).ToListAsync();
        }
        public async Task<Sacana> CreateAsync(Sacana book)
        {
            await _book.InsertOneAsync(book);
            return book;
        }



    }
}
