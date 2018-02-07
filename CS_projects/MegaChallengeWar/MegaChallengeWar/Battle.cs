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
               war(player1, player2);
                
            }
            if (card1.CardValue() > card2.CardValue())
            {
                awardWinner(player1);
            }
            else
            {
                awardWinner(player2);
            }
            return result;
        }

        private void awardWinner(Player player)
        {
            if (bounty.Count == 0)
            {
                return;
            }
            displayBountyCards();
            player.Cards.AddRange(bounty);
            bounty.Clear();
            result += "<br/><strong>" + player.Name + " wins!</strong>";

        }

        private void war(Player player1, Player player2)
        {
            result += "<br/><h3>========== WAR ==========</h3>";
            getCard(player1);
            Card warCard1 = getCard(player1);
            getCard(player1);

            getCard(player2);
            Card warCard2 = getCard(player2);
            getCard(player2);

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