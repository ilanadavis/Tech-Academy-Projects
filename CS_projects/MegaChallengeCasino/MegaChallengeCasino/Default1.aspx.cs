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
        //image of reels are random
        Random random = new Random();

        //player begins with 100
       double playersMoney = 100;
       double betAmount = 0;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (betTextBox.Text.Trim().Length == 0)
            {

            }

            else
            {
                Double.TryParse(betTextBox.Text, out betAmount);
            }
            if (ViewState["Players Money"] != null)
            {
                playersMoney = (double)ViewState["Players Money"];
            }
            else
            {

            }

            if (!Page.IsPostBack)
            {
                reelOne.ImageUrl = reelImageDisplay();
                reelTwo.ImageUrl = reelImageDisplay();
                reelThree.ImageUrl = reelImageDisplay();


                ViewState.Add("Players Money", playersMoney);
                ViewState.Add("Bet Amount", betAmount);

            } else
            {
                //
            }
        }
       
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

            reelOne.ImageUrl = reelImageDisplay();
            reelTwo.ImageUrl = reelImageDisplay();
            reelThree.ImageUrl = reelImageDisplay();
            if (winORlose(betAmount))
            {
                // won text
                resultLabel.Text = String.Format("You bet {0:C} and won! You've got {1:C}!", betAmount, playersMoney);
            }
            else
            {
                // lost text
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time. You have {1:C} to bet.", betAmount, playersMoney);
            }
            ViewState.Add("Players Money", playersMoney);
            ViewState.Add("Bet Amount", betAmount);
        }

        //if the player is a winner then add betAmount to playersMoney. Else subtract betAmount from playersMoney
        public bool winORlose(double betAmount)
        {


            //reels with a bar lose
            if (anyReelMatch("images/Bar.png"))
            {
//                displayResultLose(betAmount, playersMoney);
                playersMoney = playersMoney - betAmount;
                return false;
            }
            //reels with 1 cherry wins 2x bet
            //reels with 2 cherries wins 3x bet
            //reels with 3 cherries wins 4x bet
            else if (anyReelMatch("images/Cherry.png"))
            {
//                displayResultsWin(betAmount, playersMoney);
                playersMoney = playersMoney + ((countReelMatch("images/Cherry.png") + 1) * betAmount);
                return true;
            }
            //reels with 3 7s wins 100x bet
            else if (allReelMatch("images/Seven.png"))
            {
//                displayResultsWin(betAmount, playersMoney);
                playersMoney = playersMoney + (betAmount * 100);
                return true;
            }
            else
            {
                //               displayResultLose(betAmount, playersMoney);
                playersMoney = playersMoney - betAmount;
                return false;
            }



        }

        public bool anyReelMatch(string reelImageToMatch)
        {
            return (reelOne.ImageUrl == reelImageToMatch || reelTwo.ImageUrl == reelImageToMatch || reelThree.ImageUrl == reelImageToMatch);
        }
        public bool allReelMatch(string reelImageToMatch)
        {
            return (reelOne.ImageUrl == reelImageToMatch && reelTwo.ImageUrl == reelImageToMatch && reelThree.ImageUrl == reelImageToMatch);
        }
       
        //check each reel indiv and if it matches, increment counter and return counter at the end
        public int countReelMatch(string reelImageToMatch)
        {
            int counter = 0;
            if (reelOne.ImageUrl == reelImageToMatch)
            {
                counter += 1;
            }
            if (reelTwo.ImageUrl == reelImageToMatch)
            {
                counter += 1;
            }
            if (reelThree.ImageUrl == reelImageToMatch)
            {
                counter += 1;
            }
            return counter;
        }

        //results are displayed that shows if player won and displays running balance for playersMoney
        public void displayResultsWin (double betAmount, double playersMoney)
        {
            ViewState.Add("Players Money", playersMoney);
            ViewState.Add("Bet Amount", betAmount);

            resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", betAmount, playersMoney);

        }
        //results are displayed that shows if player lost and displays running balance for playersMoney
        public void displayResultLose (double betAmount, double playersMoney)
        {
            ViewState.Add("Players Money", playersMoney);
            ViewState.Add("Bet Amount", betAmount);

            resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time. You have {1:C} to bet.", betAmount, playersMoney);

        }

        /* public void displayResults(double betAmount, double playersMoney)
         {
             ViewState["Players Money"] = playersMoney;

             if (winORlose(betAmount) =  )
             {
            resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time. You have {1:C} to bet.", betAmount, playersMoney);
             }
             else
             {
                 resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", betAmount, playersMoney);
             }

         }
         */
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
