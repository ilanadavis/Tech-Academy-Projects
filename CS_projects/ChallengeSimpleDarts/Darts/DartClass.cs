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
                    OuterDouble = true;
                }
                //and a five percent chance of landing in the inner band that represents a triple score
                else if (chance > 5 && chance <= 10)
                {
                    InnerTriple = true;
                }
                else
                {
                }
            }
            else if (Hit < 1)
            {
                //There's only a five percent chance that the inner bullseye can be hit.
                if (chance <= 5)
                {
                    InnerBullseye = true;
                }
                else
                {
                    OuterBullseye = true;
                }
            }
            return Hit;

        }
    }
    
}


