using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistance
{
    public class OrderRepository
    {
        public static void CreateOrder()
        {
            var db = new PapaBobsDbEntities();

            var order = new Order();
            /*
order.Order_ID = Guid.NewGuid();
order.Size = 1;
order.Crust = 0;
order.Pepperoni = true;
order.Green_Peppers = true;
order.Name = "Testing";
order.Address = "123 AddressTest";
order.Zip = "12345";
order.Phone = "5555555";
order.PaymentType = 0;
order.Total_Cost = 16.50M;
*/
            db.Orders.Add(order);
            db.SaveChanges();

        }
    }
}
