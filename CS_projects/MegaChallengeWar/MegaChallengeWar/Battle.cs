using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Battle
    {
        private List<Card> bounty;
        string result = "";
        public Battle()
        {
            bounty = new List<Card>();
        }

        public string PerformBattle(Player player1, Player player2)
        {
            Card player1Card = getCard(player1);
            Card player2Card = getCard(player2);

            performEvaluation(player1, player2, player1Card, player2Card);
            return ("<h2>Begin Battle...</h2>" + displayBattleCards(player1Card, player2Card) + result);

        }

        private Card getCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            bounty.Add(card);
            return card;
        }

        private string performEvaluation(Player player1, Player player2, Card card1, Card card2)
        {
            displayBattleCards(card1, card2);
            if (card1.CardValue() == card2.CardValue())
            {
                result += "<br/><h3>========== WAR ==========</h3>";
                war(player1, player2);
                
            }
            if (card1.CardValue() > card2.CardValue())
            {
                awardWinner(player1);
                result += "<br/><span style='color:red;font-weight:bolder;'>Player 1 Wins</span>";
            }
            else
            {
                awardWinner(player2);
                result += "<br/><span style='color:blue;font-weight:bolder;'>Player 2 Wins</span>";
            }
            return result;
        }

        private void awardWinner(Player player)
        {
            displayBountyCards();
            player.Cards.AddRange(bounty);
            bounty.Clear();

        }

        private void war(Player player1, Player player2)
        {
            getCard(player1);
            getCard(player1);
            Card warCard1 = getCard(player1);

            getCard(player2);
            getCard(player2);
            Card warCard2 = getCard(player2);

            performEvaluation(player1, player2, warCard1, warCard2);
        }

        private string displayBattleCards(Card card1, Card card2)
        {
            return "<br/>Battle Cards: " + card1.Kind + " of " + card1.Suit + " verses " + card2.Kind + " of " + card2.Suit;
        }

        private string displayBountyCards()
        {
            result += "<br/>Bounty ...";
            foreach (var card in bounty)
            {
                result += "<br/>&nbsp;&nbsp;&nbsp;&nbsp;" + card.Kind + " of " + card.Suit;
            }
            return result;
        }
    }
}