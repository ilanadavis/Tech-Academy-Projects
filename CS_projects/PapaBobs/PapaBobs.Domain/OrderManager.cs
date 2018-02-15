using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PapaBobs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder()
        {
            Persistance.OrderRepository.CreateOrder();
        }
    }
}