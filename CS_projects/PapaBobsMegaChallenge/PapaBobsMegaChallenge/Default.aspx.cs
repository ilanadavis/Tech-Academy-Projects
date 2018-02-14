using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaBobs.Persistance;

namespace PapaBobs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();

            pizza.PizzaSize = sizeDropDownList.SelectedValue;
            pizza.Crust = crustDropDownList.SelectedValue;


            if (sausageCheckBox.Checked)
            {
                pizza.Toppings.Add(new Topping() { Name = "Sausage" });
            }
            if (pepperoniCheckBox.Checked)
            {
                pizza.Toppings.Add(new Topping() { Name = "Pepperoni" });
            }
            if (onionsCheckBox.Checked)
            {
                pizza.Toppings.Add(new Topping() { Name = "Onions" });
            }
            if (greenpeppersCheckBox.Checked)
            {
                pizza.Toppings.Add(new Topping() { Name = "Green Peppers" });
            }

            TextValidator();
            resultLabel.Text = String.Format("{0:C}",pizza.totalCost());
        }

        public void TextValidator()
        {
            string msg = "";

            foreach (IValidator aValidator in this.Validators)
            {
                if (!aValidator.IsValid)
                {
                    msg += "<br />" + aValidator.ErrorMessage;
                }
            }
            //resultLabel.Text = msg;
        }

    }
}

//method that pulls the results from the default page