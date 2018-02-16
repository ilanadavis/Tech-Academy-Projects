using System;
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


            var order = buildOrder();

            Domain.OrderManager.CreateOrder(order);
        }

        private DTO.Enums.Size determineSize()
        {
            DTO.Enums.Size size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Please select a size");
            }
            return size;
        }

        private DTO.Enums.CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Please select a crust type");
            }
            return crust;
        }

        private DTO.Enums.PaymentType determinePaymentType()
        {
            DTO.Enums.PaymentType paymenttype;
            if (cashRadioButton.Checked)
            {
                paymenttype = DTO.Enums.PaymentType.Cash;
            }
            else 
            {
                paymenttype = DTO.Enums.PaymentType.Credit;
            }

            return paymenttype;
        }

        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty) return;
            if (crustDropDownList.SelectedValue == String.Empty) return;

            var order = buildOrder();

            resultLabel.Text = Domain.PizzaPriceManager.CalculateCost(order).ToString("C");

            
        }

        private DTO.OrderDTO buildOrder()
        {
            var order = new DTO.OrderDTO();

            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenpeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;

            order.PaymentType = determinePaymentType();

            return order;
        }

    }
}