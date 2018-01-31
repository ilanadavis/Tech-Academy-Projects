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
            //if viewstate has data use or use reset
            if (ViewState["Player1 Results"] == null)
            {
                double resultPlayer1 = new double();
                ViewState.Add("Player1 Results", resultPlayer1);
            }
            if (ViewState["Player2 Results"] == null)
            {
                double resultPlayer2 = new double();
                ViewState.Add("Player2 Results", resultPlayer2);
            }


        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //When you call the Throw() method it will simulate the act of throwing a dart at a dart board.
            double player1Score = (double)ViewState["Player1 Results"];
            double player2Score = (double)ViewState["Player2 Results"];

            GameClass Game = new GameClass();
            double resultPlayer1 = Game.Player1();
            double resultPlayer2 = Game.Player2();

            double totalScorePlayer1 = player1Score + resultPlayer1;
            ViewState["Player1 Results"] = totalScorePlayer1;

            double totalScorePlayer2 = player2Score + resultPlayer2;
            ViewState["Player2 Results"] = totalScorePlayer2;

            resultLabel.Text = string.Format("<p>Player1 this round: {0}  Player1 total {2}<p>Player2 this round: {1}   Player 2 total {3}",resultPlayer1, resultPlayer2, totalScorePlayer1, totalScorePlayer2);
        }
 

    }
}

/*
    (3) In the Web Forms project create a Score class that contains a static method 
that will calculate the score for a dart throw.  
*/
