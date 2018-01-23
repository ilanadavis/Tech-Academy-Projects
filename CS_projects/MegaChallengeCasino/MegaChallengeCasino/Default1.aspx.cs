using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            reelOne.ImageUrl = reelImageDisplay();
            reelTwo.ImageUrl = reelImageDisplay();
            reelThree.ImageUrl = reelImageDisplay();
        }
        //image of reels are random
        Random random = new Random();
       
        //player begins with 100
        int playersMoney = 100;
        int betAmount = 0;


        //images on the reels
        public string reelImageDisplay()
            {
            string[] reelImages = new string[] { "images/Strawberry.png", "images/Bar.png", "images/Lemon.png", "images/Bell.png", "images/Clover.png", "images/Cherry.png", "images/Diamond.png", "images/Orange.png", "images/Seven.png", "images/HorseShoe.png", "images/Plum.png", "images/Watermelon.png" };
            return reelImages[random.Next(11)];
            }

        protected void betTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        protected void leverButton_Click(object sender, EventArgs e)
        {
        }

        private void calculatePlayersMoney(double playersMoney, double playersBet)
        {
            if (betTextBox.Text.Trim().Length == 0)
                return;

            if (!Double.TryParse(betTextBox.Text, out betAmount))
                return;

            
        }
        //following code is to be deleted
        private void calculateCups(double measureToCupRatio, string measureName)
        {
            if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            //define an input parameter called measureToCupRatio
            double cups = quantity * measureToCupRatio;



        private void displayResults(int betTextBox, int playersMoney)
        {
            if (reelImageDisplay() == "images/Bar.png")
            {
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", betTextBox);
            }
            else
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", betTextBox, playersMoney);
            }
        
        }


    }
}
/*
Enter number into betTextBox
When button clicked, random image appears. 

Determine the value of the pull.
 - bar
 - jackpot
 - cherries

Set players new money total.
Calculate win/loss
Persist it to viewstate

*/
