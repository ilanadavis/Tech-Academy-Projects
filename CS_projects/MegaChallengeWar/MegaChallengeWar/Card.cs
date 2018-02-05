using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Card
    {
        private int rank;
        private int suit;

        public Card (int theSuit, int theRank)
        {
            rank = theRank;
            suit = theSuit;
        }

        public String results()            
        {
            String rankString = "";
            String suitString = "";
            string result = "";
            {
                //rank 2-Ace where Ace is high
                if (rank == 11)
                {
                    rankString = "Jack";
                }
                if (rank == 12)
                {
                    rankString = "Queen";
                }
                if (rank == 13)
                {
                    rankString = "King";
                }
                if (rank == 14)
                {
                    rankString = "Ace";
                }
                else
                {
                    rankString += rank;
                }
                return rankString;
                
                //suit hearts, diamonds, clubs, spades
                if (suit == 1)
                {
                    suitString = "Hearts";
                }
                if (suit == 2)
                {
                    suitString = "Diamonds";
                }
                if (suit == 3)
                {
                    suitString = "Clubs";
                }
                else
                {
                    suitString += "Spades";
                }
                return suitString;
            }
            result = rankString + "of" + suitString;

        }
    }
}