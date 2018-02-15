using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PapaBobs.Persistance
{
    public class OrderRepository
    {
        public static void CreateOrder()
        {
            var db = new PapaBobsDbEntities();

            var order = new Order();

            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.Size.Large;
            order.Crust = 0;
            order.Pepperoni = true;
            order.GreenPeppers = true;
            order.Name = "Testing";
            order.Address = "123 AddressTest";
            order.Zip = "12345";
            order.Phone = "5555555";
            order.PaymentType = 0;
            order.TotalCost = 16.50M;

            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}