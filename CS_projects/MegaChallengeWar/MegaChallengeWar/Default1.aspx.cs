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
            foreach (var card in deck._deck)
            {
                resultLabel.Text += "<br/>" + card.Suit + " " + card.Kind;
            }
            //deck.Shuffle();
            //deck.DealCard();


            /*
            for (int i = 0; i < 26; i++)
            {
                resultLabel.Text += String.Format("Player1 Hand: <br/>{0,-19}<br/>", deck1.DealCard());
            }
            else
            {
                resultLabel.Text += String.Format("Player2 Hand: <br/>{0,-19}<br/>", deck1.DealCard());
            }
          
            */
        }
    }
}