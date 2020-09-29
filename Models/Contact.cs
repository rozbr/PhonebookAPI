
using System.Collections.Generic;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PhonesbookAPI.Models {
  public class Contact {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("address")]
    public Dictionary<string, string> Address { get; set; }

    [BsonElement("emails")]
    public List<Dictionary<string, string>> Emails { get; set; }

    [BsonElement("telefones")]
    public List<Dictionary<string, string>> Telefones { get; set; }
  }
}
