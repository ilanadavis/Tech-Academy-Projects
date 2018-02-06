using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class CardDeck
    {
        private List<Card> deck;
        private Random random;
        string results = "";

        public CardDeck()
        {
            deck = new List<Card>();
            random = new Random();

            string[] kinds = new string[]{ "2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"};
            string[] suits = new string[]{ "Hearts", "Clubs", "Diamonds", "Spades" };

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {
                    deck.Add(new Card() { Suit = suit, Kind = kind });
                }
            }
        }


        public string Deal(Player player1, Player player2)
        {
            while (deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);
            }
            return results;
        }

        private void dealCard (Player player)
        {
            Card card = deck.ElementAt(random.Next(deck.Count));
            player.Cards.Add(card);
            deck.Remove(card);

            results += "<br/>" + player.Name + " is delt the " + card.Kind + " of " + card.Suit;
        }
    }

    
}
