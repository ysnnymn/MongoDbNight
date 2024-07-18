using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbNight.Entities
{
    public class Category
    {
        [BsonId]//CateyoryId'nin Id Oldugunu bildirir
        [BsonRepresentation(BsonType.ObjectId)]//Id'nin bensersiz deger almasını sağlar.
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
