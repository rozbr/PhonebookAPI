
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PhonesbookAPI.Models {
  public class Contact {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }
  }
}
