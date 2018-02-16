using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PapaBobs.Domain
{
    public class Pizza
    {
        public string PizzaSize { get; set; }
        public string Crust { get; set; }
        public List<Topping> Toppings = new List<Topping>() { };


        string resultCost = "";

        public double pizzaSizeCost()
        {
            if (PizzaSize == "Small")
            {
                return 12;
            }
            if (PizzaSize == "Medium")
            {
                return 14;
            }
            if (PizzaSize == "Large")
            {
                return 16;
            }
            return 0; //Add exception

        }

        public double pizzaCrustCost()
        {
            if (Crust == "Regular")
            {
                return 0;
            }
            if (Crust == "Thin")
            {
                return 0;
            }
            if (Crust == "Thick")
            {
                return 2;
            }
            return 0; //Add exception
        }

        public double toppingsCost()
        {
            double costofTopping = 0;
            foreach (var topping in Toppings)
            {
                if (topping.Name == "Sausage")
                {
                    costofTopping += 2;
                }
                if (topping.Name == "Pepperoni")
                {
                    costofTopping += 1.5;
                }
                if (topping.Name == "Onions")
                {
                    costofTopping += 1;
                }
                if (topping.Name == "Green Peppers")
                {
                    costofTopping += 1;
                }
                else
                {
                    costofTopping += 0;
                }
            }
            return costofTopping;
        }

        public double totalCost()
        {
            double costTotals = pizzaSizeCost() + pizzaCrustCost() + toppingsCost();
            resultCost += costTotals;
            return costTotals;
        }


        // method to determine cost based on the property selected

    }
}