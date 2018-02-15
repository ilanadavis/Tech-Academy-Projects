﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
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

            Domain.OrderManager.CreateOrder(order);

        }
    }
}