using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public static class Score
    {
        public static double score = 0;
        
        public static double scoreDart(Dart dart)
        {

            if (dart.OuterDouble)
            {
                score = dart.Hit * 2;
            }
            else if (dart.InnerTriple == true)
            {
                score = dart.Hit * 3;
            }
            else if (dart.OuterBullseye == true)
            {
                score = 25;
            }
            else if (dart.InnerBullseye == true)
            {
                score = 50;
            }
            else
            {
                score = dart.Hit;
            }
            return score;
        }     
    }
}

/*
* Each dart can score from 1 to 20, or the bullseye.
If the dart lands in the outer band, multiply the dart's score by two.  
If the dart lands in the inner band, multiply the dart's score by three.  
If the dart lands in the outer bullseye, it is scored as 25.  
If the dart lands in the inner bullseye, it is scored as 50.
*/
