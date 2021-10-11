using MongoDB.Bson.Serialization.Attributes;

namespace ApiMongo.Models
{
    [BsonIgnoreExtraElements]
    public class Film
    {
        [BsonId]
        public int Id { get; set; }
        
        [BsonElement]
        public string Title { get; set; }
        [BsonElement]
        public string Direction { get; set; }
        [BsonElement]
        public int Year { get; set; }
        [BsonElement]
        public int ClientId { get; set; }

    }
}