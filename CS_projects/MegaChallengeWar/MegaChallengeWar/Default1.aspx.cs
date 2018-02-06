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

            Game game = new Game("Player 1", "Player 2");
            resultLabel.Text += "<h2>Dealing cards...</h2>" + game.Play();
            resultLabel.Text += "<h2>Begin Battle...</h2>";
        }
    }
}