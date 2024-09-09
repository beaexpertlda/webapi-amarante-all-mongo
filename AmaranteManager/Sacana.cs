using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace webapi_amarante_all.AmaranteManager
{
    public class Sacana
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string? Nome { get; set; }

        public string? Apelido { get; set; }
    }
}
