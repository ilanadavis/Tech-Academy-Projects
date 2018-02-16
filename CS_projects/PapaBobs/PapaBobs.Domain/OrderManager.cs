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
            //Validation is in the default.aspx css code

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO);
            Persistance.OrderRepository.CreateOrder(orderDTO);
            
        }

        public static object GetOrders()
        {
            return Persistance.OrderRepository.GetOrders();
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistance.OrderRepository.CompleteOrder(orderId);
        }
    }
}