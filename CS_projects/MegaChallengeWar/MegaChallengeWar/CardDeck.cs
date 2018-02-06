using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class CardDeck
    {
        private static Random random = new Random();
        public List<Card> Cards { get; set; }

        private int currentCard;
        private const int FullDeck = 52;

        public void Deck()
        {
            string[] faces = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            int[] faceValue = { 2,3,4,5,6,7,8,9,10,11,12,13,14 };

            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            currentCard = 0;
            random = new Random();

            foreach (var current in faceValue)
            {
                deck.Add(new Card(current, "Hearts"));
            }
            foreach (var current in faceValue)
            {
                deck.Add(new Card(current, "Clubs"));

            }
            foreach (var current in faceValue)
            {
                deck.Add(new Card(current, "Diamonds"));

            }
            foreach (var current in faceValue)
            {
                deck.Add(new Card(current, "Spades"));

            }

        }


        
        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Count; first++)
            {
                int second = random.Next(FullDeck);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Count)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}