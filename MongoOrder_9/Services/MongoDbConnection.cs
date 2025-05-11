using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoOrder_9.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database; //field oluşturduk

        public MongoDbConnection() //constructor oluşturduk
        {
            //constructor çağırdığımız zaman bizim için bir nesne örneği oluşturacak hafıza da 
            //ve ona direkt erişim sağlayabileceğiz
           var client = new MongoClient("mongodb://localhost:27017"); //burası bağlant adresim
            _database = client.GetDatabase("Db9ProjectOrder"); //burada database adını belirttik.
        }
        public IMongoCollection<BsonDocument> GetOrdersCollection()
        {
            //burada ise tablolarımızı belirteceğiz
            return _database.GetCollection<BsonDocument>("Orders");
        }
    }
}
