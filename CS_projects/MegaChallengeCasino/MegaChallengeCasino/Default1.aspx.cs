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
            reelOne.ImageUrl = ImageDisplay();
            reelTwo.ImageUrl = ImageDisplay();
            reelThree.ImageUrl = ImageDisplay();
        }



        public string ImageDisplay()
            {
            string[] images = new string[] { "images/Strawberry.png", "images/Bar.png", "images/Lemon.png", "images/Bell.png", "images/Clover.png", "images/Cherry.png", "images/Diamond.png", "images/Orange.", "images/Seven.png", "images/HorseShoe.png", "images/Plum.png", "images/Watermelon.png" };
            Random random = new Random();
            return images[random.Next(11)];
            }
        protected void leverButton_Click(object sender, EventArgs e)
        {

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

Start with $100
Reels are random
Lose: Sorry, you lost $5.00. Better luck next time.
Win: You bet $5.00 and won $10.00!
*/
