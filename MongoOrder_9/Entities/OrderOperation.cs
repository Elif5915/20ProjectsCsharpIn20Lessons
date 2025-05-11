using MongoDB.Bson;
using MongoDB.Driver;
using MongoOrder_9.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoOrder_9.Entities
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderOperation = connection.GetOrdersCollection();

            var document = new BsonDocument
            {
                {"CustomerName",order.CustomerName },
                {"District", order.District },
                {"City",order.City },
                {"TotalPrice", BsonDecimal128.Create(order.TotalPrice)}
            };
            orderOperation.InsertOne(document);
            //InsertOne metodu mongodb ekleme işlemi yapar
        }
        public List<Order> GetAllOrder()
        {
            var connection = new MongoDbConnection();
            var orderOperation = connection.GetOrdersCollection();

            var orders = orderOperation.Find(new BsonDocument()).ToList();
            List<Order> orderlist = new List<Order>();
            foreach(var doc in orders)
            {
                orderlist.Add(new Order
                {
                    City = doc["City"].ToString(),
                    CustomerName = doc["CustomerName"].ToString(),
                    District = doc["District"].ToString(),
                    OrderId = doc["_id"].ToString(),
                    TotalPrice = decimal.Parse(doc["TotalPrice"].ToString())
                });
            }
            return orderlist;
        }
        public void DeleteOrder(string orderId)
        {
            var connection = new MongoDbConnection();
            var orderOperation = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId)); //silinecek değeri bulma işlemi yapılmalı buradaki gibi
            orderOperation.DeleteOne(filter);
        }
        public void UpdateOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderOperation = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var updateValue = Builders<BsonDocument>.Update
                .Set("CustomerName", order.CustomerName)
                .Set("City", order.City)
                .Set("District", order.District)
                .Set("TotalPrice", order.TotalPrice);
            orderOperation.UpdateOne(filter, updateValue);


        }
        public Order GetOrderById(string orderId)
        {
            var connection = new MongoDbConnection();
            var orderOperation = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var result = orderOperation.Find(filter).FirstOrDefault();
            if(result != null)
            {
                return new Order
                {
                    City = result["City"].ToString(),
                    CustomerName = result["CustomerName"].ToString(),
                    District = result["District"].ToString(),
                    TotalPrice = decimal.Parse(result["TotalPrice"].ToString())
                };
            }
            else
            {
                return null;
            }

        }
    }
}
