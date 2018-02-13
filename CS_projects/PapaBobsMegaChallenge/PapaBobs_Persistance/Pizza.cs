using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistance
{
    public class Pizza
    {
        public string PizzaSize { get; set; }
        public string Crust { get; set; }
        public string Toppings { get; set; } //list

        string resultCost = "";
        

        public int sizeSubTotal;
        public int pizzaSizeCost()
        {
            if (PizzaSize == "Small")
            {
                sizeSubTotal = 12;
            }
            if (PizzaSize == "Medium")
            {
                sizeSubTotal = 14;
            }
            if (PizzaSize == "Large")
            {
                sizeSubTotal = 16;
            }
            return sizeSubTotal;
        }

        public int crustSubTotal;
        public int pizzaCrustCost()
        {
            if (Crust == "Regular")
            {
                crustSubTotal = 0;
            }
            if (Crust == "Thin")
            {
                crustSubTotal = 0;
            }
            if (Crust == "Thick")
            {
                crustSubTotal = 2;
            }
            return crustSubTotal;
        }
        
        public int costTotals;
        public int totalCost()
        {
            costTotals = pizzaSizeCost() + pizzaCrustCost();
            resultCost += costTotals;
            return costTotals;
        }


        // method to determine cost based on the property selected

    }
}
