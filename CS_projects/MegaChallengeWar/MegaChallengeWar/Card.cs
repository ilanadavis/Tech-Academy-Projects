using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Card
    {
        private int face;
        private string suit;


        //constructor
        public Card(int cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        //
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}