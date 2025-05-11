using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoOrder_9.Entities
{
    public class Order
    {
        //Mongo db de id değeri integer, identity spec. şeklinde artmaz tutulmaz.
        //mongo db de id string ve değeri guid id şeklinde tutulmaktadır.
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
