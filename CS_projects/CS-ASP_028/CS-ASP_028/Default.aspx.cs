using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_028
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cupsRadio_CheckedChanged(object sender, EventArgs e)
        {
            //using the method from below in each section rather than typing out code for each one
            //calculateCups();

            calculateCups(1.0, "cups");



            /*  if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            resultLabel.Text = "The number of cups: " + quantity.ToString();
            */
        }

        protected void fromPintsRadio_CheckedChanged(object sender, EventArgs e)
        {
            //using the method from below in each section rather than typing out code for each one
            //calculateCups();

            calculateCups(2.0, "pints");

            /* if (quantityTextBox.Text.Trim().Length == 0)
                 return;

             double quantity = 0.0;
             if (!Double.TryParse(quantityTextBox.Text, out quantity))
                 return;

             double cups = quantity * 2.0;
             resultLabel.Text = "The number of cups: " + cups.ToString();
             */
        }

        protected void fromQuartsRadio_CheckedChanged(object sender, EventArgs e)
        {

            //using the method from below in each section rather than typing out code for each one
            // calculateCups();
            calculateCups(4.0, "quarts");


            /*  if (quantityTextBox.Text.Trim().Length == 0)
                  return;

              double quantity = 0.0;
              if (!Double.TryParse(quantityTextBox.Text, out quantity))
                  return;

              double cups = quantity * 4.0;
              resultLabel.Text = "The number of cups: " + cups.ToString();
              */
        }

        protected void fromGallonsRadio_CheckedChanged(object sender, EventArgs e)
        {

            //using the method from below in each section rather than typing out code for each one
            //calculateCups();

            calculateCups(16.0, "gallons");


            /* if (quantityTextBox.Text.Trim().Length == 0)
                 return;

             double quantity = 0.0;
             if (!Double.TryParse(quantityTextBox.Text, out quantity))
                 return;

             double cups = quantity * 16.0;
             resultLabel.Text = "The number of cups: " + cups.ToString();
             */
        }

        protected void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            //using the method from below in each section rather than typing out code for each one
          //  calculateCups();
        }


        //creates a method that can be called above rather than having to type each if statement for each radio button (DRY dont repeat yourself)
        /*
        private void calculateCups()
        {
            if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            double cups = 0.0;
            if (fromCupsRadio.Checked) cups = quantity;
            else if (fromPintsRadio.Checked) cups = quantity * 2;
            else if (fromQuartsRadio.Checked) cups = quantity * 4;
            else if (fromGallonsRadio.Checked) cups = quantity * 16;

            resultLabel.Text = "The number of cups: " + cups.ToString();
            */


            //working with input parameters to eliminate the code directly above
        private void calculateCups(double measureToCupRatio, string measureName)
        {
            if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            //define an input parameter called measureToCupRatio
            double cups = quantity * measureToCupRatio;
           

            resultLabel.Text = String.Format("{0:N2} {1} is equal to {2:N2} cups.", quantity, measureName, cups);
        }
    }
}