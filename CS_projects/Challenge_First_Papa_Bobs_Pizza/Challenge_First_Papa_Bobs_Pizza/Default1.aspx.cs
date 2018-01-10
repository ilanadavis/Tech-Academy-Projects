using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_First_Papa_Bobs_Pizza
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            double sizeSubtotal = 0.00;
            double crustSubtotal = 0.00;
            double toppingSubtotal = 0.00;
            double specialDeal = 0.00;

            // Size selections and cost
            if (babyRadioButton.Checked)
            {
                sizeSubtotal = 10.00;
            }
            else if (mamaRadioButton.Checked)
            {
                sizeSubtotal = 13.00;
            }
            else if (papaRadioButton.Checked)
            {
                sizeSubtotal = 16.00;
            }
            else
            {
                sizeSubtotal = 0.00;
            }

            // Crust selection and cost
            if (thincrustRadioButton.Checked)
            {
                crustSubtotal = 0.00;
            }
            else if (deepdishRadioButton.Checked)
            {
                crustSubtotal = 2.00;
            }
            else
            {
                crustSubtotal = 0.00;
            }

            // Topping selection and cost
            if (pepperoniCheckBox.Checked)
            {
                toppingSubtotal = toppingSubtotal + 1.50;
            }
            if  (onionCheckBox.Checked)
            {
                toppingSubtotal = toppingSubtotal + 0.75;
            }
            if (greenpeppersCheckBox.Checked)
            {
                toppingSubtotal = toppingSubtotal + 0.50;
            }
            if (redpeppersCheckBox.Checked)
            {
                toppingSubtotal = toppingSubtotal + 0.75;
            }
            if (anchoviesCheckBox.Checked)
            {
                toppingSubtotal = toppingSubtotal + 2.00;
            }


            // total calculation
            if ((pepperoniCheckBox.Checked && greenpeppersCheckBox.Checked && anchoviesCheckBox.Checked) 
                || (pepperoniCheckBox.Checked && redpeppersCheckBox.Checked && onionCheckBox.Checked))
                    {
                specialDeal = -2.00;
            }
            else
            {
                specialDeal = 0.00;
            }
            resultLabel.Text = (sizeSubtotal + crustSubtotal + toppingSubtotal + specialDeal).ToString();


        }
    }
}