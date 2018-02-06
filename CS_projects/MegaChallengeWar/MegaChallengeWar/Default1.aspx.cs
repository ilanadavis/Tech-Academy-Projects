using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class Default1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            CardDeck deck = new CardDeck();
            deck.Shuffle();
            deck.DealCard();
            resultLabel.Text = String.Format("{0}",deck.DealCard());

            


            /*
            for (int i = 0; i < 52; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    resultLabel.Text += String.Format("Player1 Hand: <br/>{0,-19}<br/>", deck1.DealCard());
                }
                else
                {
                    resultLabel.Text += String.Format("Player2 Hand: <br/>{0,-19}<br/>", deck1.DealCard());
                }
            }
            */
        }
    }
}