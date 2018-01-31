using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;


namespace ChallengeSimpleDarts
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //When you call the Throw() method it will simulate the act of throwing a dart at a dart board.

            GameClass Game = new GameClass();
            double resultPlayer1 = Game.Player1();
            double resultPlayer2 = Game.Player2();

            resultLabel.Text = string.Format("<p>Player1: {0}<p>Player2: {1}", resultPlayer1, resultPlayer2);
        }
 

    }
}

/*
    (3) In the Web Forms project create a Score class that contains a static method 
that will calculate the score for a dart throw.  
*/
