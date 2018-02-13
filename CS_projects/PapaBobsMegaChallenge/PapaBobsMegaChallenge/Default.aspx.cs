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

            resultLabel.Text = String.Format("{0:C}",pizza.totalCost());
        }
    }
}

//method that pulls the results from the default page