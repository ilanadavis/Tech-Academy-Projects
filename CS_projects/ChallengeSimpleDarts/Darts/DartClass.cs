using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        System.Random random = new Random();
        
        public bool OuterDouble { get; set; }
        public bool InnerTriple { get; set; }
        public bool OuterBullseye { get; set; }
        public bool InnerBullseye { get; set; }
        public double Hit { get; set; }


        public double Throw()
        {
            
            OuterDouble = false;
            InnerTriple = false;
            OuterBullseye = false;
            
            double dartThrow = 0;

            //The dart has an equal chance of scoring one through twenty, or the bullseye(0).
            Hit = random.Next(0, 20);
            double chance = random.Next(0,100);
            if (Hit >= 1 && Hit <= 20)
            {
                // For numbers 1 through 20, the dart has a five percent chance of landing in the outer band that represents a double score
                dartThrow = Hit;
                if (chance <= 5)
                {
                    dartThrow = dartThrow * 2; //outer band
                    //OuterDouble = true;
                }
                //and a five percent chance of landing in the inner band that represents a triple score
                else if (chance > 5 && chance <= 10)
                {
                    dartThrow = dartThrow * 3; //inner band
                    //InnerTriple = true;
                }
                else
                {
                    dartThrow = dartThrow * 1;
                }
            }
            else if (Hit < 1)
            {
                //There's only a five percent chance that the inner bullseye can be hit.
                if (chance <= 5)
                {
                    dartThrow = 50;  //inner bullseye
                    //InnerBullseye = true;
                }
                else
                {
                    dartThrow = 25; //outer bullseye
                    //OuterBullseye = true;
                }
            }
            return dartThrow;
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
