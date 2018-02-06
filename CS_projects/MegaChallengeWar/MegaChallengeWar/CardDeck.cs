using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class CardDeck
    {
        public List<Card> _deck;

        public CardDeck()
        {
            _deck = new List<Card>();

            string[] kinds = new string[]{ "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "Kind", "Ace" };
            string[] suits = new string[]{ "Hearts", "Clubs", "Diamonds", "Spades" };

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {
                    _deck.Add(new Card() { Suit = suit, Kind = kind });
                }
            }
        }

        

        /*private static Random random = new Random();
        public List<CardDeck> Deck { get; set; }

        private int currentCard;
        private const int FullDeck = 52;

        public void newDeck()
        {
            string[] faces = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };


            currentCard = 0;
            random = new Random();
            Cards = new List<Card>();
            
            foreach (var current in faceValue)
            {
                Deck.Add(new Card(current, "Hearts"));
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
            */

    }

   
}
