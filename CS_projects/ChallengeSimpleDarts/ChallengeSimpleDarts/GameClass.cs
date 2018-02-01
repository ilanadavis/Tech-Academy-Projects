using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{

    public class GameClass
    {
        System.Random random = new Random();

        public double player1Score = 0;
        public double player2Score = 0;

        public double Player1()
        {
            Dart dartOne = new Dart(random);
            Dart dartTwo = new Dart(random);
            Dart dartThree = new Dart(random);

            dartOne.Throw();
            dartTwo.Throw();
            dartThree.Throw();
            double roundScorePlayer1 =  (Score.scoreDart(dartOne) + Score.scoreDart(dartTwo) + Score.scoreDart(dartThree));
            addplayer1Score(roundScorePlayer1);
            return roundScorePlayer1;
        }

        public double Player2()
        {
            Dart dartOne = new Dart(random);
            Dart dartTwo = new Dart(random);
            Dart dartThree = new Dart(random);

            dartOne.Throw();
            dartTwo.Throw();
            dartThree.Throw();
            double roundScorePlayer2 = (Score.scoreDart(dartOne) + Score.scoreDart(dartTwo) + Score.scoreDart(dartThree));
            addplayer2Score(roundScorePlayer2);
            return roundScorePlayer2;
        }
        //Player 1
        public void putplayer1Score(double prevScorePlayer1)
        {
            player1Score = prevScorePlayer1;
        }

        public void addplayer1Score(double newScorePlayer1)
        {
            player1Score = player1Score + newScorePlayer1;
        }
        //Player 2
        public void putplayer2Score(double prevScorePlayer2)
        {
            player2Score = prevScorePlayer2;
        }

        public void addplayer2Score(double newScorePlayer2)
        {
            player2Score = player2Score + newScorePlayer2;
        }

    }
}

/*
 * (2) In the Web Forms project, you will create a Game class that contains the 
logic for a simple game of darts.  Two players will take turns throwing three
darts per turn.  Their respective scores accumulate after each turn by adding 
the score from each dart to the Player's score.  

The first Player to reach 300 points wins.  

If the dart lands in the double or triple band, multiply the score by 2x or 3x, respectively.  

Display the winner and both player's scores on the web page.

*/
