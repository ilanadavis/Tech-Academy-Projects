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

            return deck.Deal(player1, player2);

        }
    }
}