using MongoDB.Bson;
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
                {"OrderId",order.OrderId },
                {"CustomerName",order.CustomerName },
                {"District", order.District },
                {"City",order.City },
                {"TotalPrice",order.TotalPrice }
            };
        }
    }
}
