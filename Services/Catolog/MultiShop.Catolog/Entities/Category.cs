using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catolog.Entities
{
    public class Category
    {
        [BsonId] //id olduğunu belirtir. MongoDB'deki _id alanına eşlenir.
        [BsonRepresentation(BsonType.ObjectId)] // MongoDB'deki _id alanı ObjectId türündedir. Ancak, C# tarafında bu alanı string olarak tutmak isterseniz, bu özellik kullanılır ve MongoDB sürücüsü bu string değeri ObjectId'ye çevirir.
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
