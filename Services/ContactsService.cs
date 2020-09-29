
using MongoDB.Driver;

using PhonesbookAPI.Models;


namespace PhonesbookAPI.Services {
  public class ContactsService {
    private readonly IMongoCollection<Contact> _contacts;

    public ContactsService() {
      var client = new MongoClient("mongodb://localhost:27017");
      var database = client.GetDatabase("phonebook");

      _contacts = database.GetCollection<Contact>("contacts");
    }
  }
}
