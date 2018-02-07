using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {

        private Player player1;
        private Player player2;


        public Game(string player1Name, string player2Name)
        {
            player1 = new Player() { Name = player1Name };
            player2 = new Player() { Name = player2Name };
        }

        public string Play()
        {
            CardDeck deck = new CardDeck();

            string result = deck.Deal(player1, player2);
            int round = 0;
            while (player1.Cards.Count !=0 && player2.Cards.Count !=0)
            {
                Battle battle = new Battle();
                result += battle.PerformBattle(player1, player2);

                round++;
                if (round > 20)
                    break;
            }
            //determine winner
            result += "<h2>And the winner is...</h2>" + determinewinner();
            return result;
        }
        
        public string determinewinner()
        {
            string result = "";
            if (player1.Cards.Count > player2.Cards.Count)
            {
                result += "<br/><span style='color:red;font-weight:bolder;'>Player 1 wins</span>";
            }
            else
            {
                result += "<br/><span style='color:blue;font-weight:bolder;'>Player 2 wins</span>";
            }

            result += "<br/><span style='color:red;font-weight:bolder;'>Player 1 Total Cards:" + player1.Cards.Count + "</span>" 
                + "&nbsp;&nbsp; <span style='color:blue;font-weight:bolder;'>Player 2 Total Cards:" + player1.Cards.Count + "</span>";
            return result;
        }
    }
}