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
                battle.PerformBattle(player1, player2);
                round++;
                if (round > 20)
                    break;
            }
            //determine winner
            result += determinewinner();
            return result;
        }
        
        public string determinewinner()
        {
            string result = "";
            if (player1.Cards.Count > player2.Cards.Count)
            {
                result += "<br/>Player 1 wins";
            }
            else
            {
                result += "<br/>Player 2 wins";
            }

            result += "<br/> Player 1 Total Cards:" + player1.Cards.Count + " Player 2 Total Cards:" + player1.Cards.Count;
            return result;
        }
    }
}