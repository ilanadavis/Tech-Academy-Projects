using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PapaBobs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            /*
            var order = new DTO.OrderDTO();

            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.Size.Large;
            order.Crust = DTO.Enums.CrustType.Thick;
            order.Pepperoni = true;
            order.GreenPeppers = true;
            order.Name = "Testing";
            order.Address = "123 AddressTest";
            order.Zip = "12345";
            order.Phone = "5555555";
            order.PaymentType = DTO.Enums.PaymentType.Credit;
            order.TotalCost = 16.50M;
            */

            orderDTO.OrderId = Guid.NewGuid();

            Persistance.OrderRepository.CreateOrder(orderDTO);
            
        }
    }
}