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

        public double Player1()
        {
            Dart dartOne = new Dart(random);
            Dart dartTwo = new Dart(random);
            Dart dartThree = new Dart(random);

            dartOne.Throw();
            dartTwo.Throw();
            dartThree.Throw();
            return (Score.scoreDart(dartOne) + Score.scoreDart(dartTwo) + Score.scoreDart(dartThree));
        }

        public double Player2()
        {
            Dart dartOne = new Dart(random);
            Dart dartTwo = new Dart(random);
            Dart dartThree = new Dart(random);

            dartOne.Throw();
            dartTwo.Throw();
            dartThree.Throw();
            return (Score.scoreDart(dartOne) + Score.scoreDart(dartTwo) + Score.scoreDart(dartThree));

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
