using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculatorHelperMethods
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Ground: .15 multiplier
            parcelCost(0.15, "Ground");

        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Air: .25 multiplier
            parcelCost(0.25, "Air");
        }

        protected void nextdayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Next Day: .45
            parcelCost(0.45, "Next Day");

        }

        //Only job is to check to see that the fields are entered
        private bool validatingRequiredData()
        {
            if (widthTextBox.Text.Trim().Length == 0) return false;
            if (heightTextBox.Text.Trim().Length == 0) return false;
            return true;
        }


        private void parcelCost(double shippingMultiplier, string shippingMethod)
        {
            if (!validatingRequiredData()) return;
            
            double width = TryParseDouble(widthTextBox.Text);
            double height = TryParseDouble(heightTextBox.Text);
            double length = TryParseDouble(lengthTextBox.Text);

       
            //The result will be the volume of the package (width * height and optionally * length) multiplied by the "multiplier" for each shipping method.

            double volume = width * height * length;
            double parcelCost = volume * shippingMultiplier;

        
            //product result on screen: 
            resultLabel.Text = String.Format("Your parcel will cost {0:C2} to ship.", parcelCost);
        }

        //using text fields and converting to doubles or if not, return
        private double TryParseDouble (string measurment)
        {
            double dimension;
            if (!Double.TryParse(measurment, out dimension)) return 1;
            return dimension;
            
        }

    }
}


//Accept width, height and optionally the length of a parcel
//Accept the shipping method - Ground, Air, Next Day
