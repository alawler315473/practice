using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingClasses
{
    class Coin
    {
        //properties
        string sideUp; 
        Random rand;

        //constructotr
        public Coin()
        {
            sideUp = "heads";
            rand = new Random()
        }

        //methods
        public void FlipCoin()
        {
            int randNum =rand.Next(2);
            if (randNum == 0)
            {
                sideUp = "Tails";
            }
            else if( randNum == 1)
            {
                sideUp = "Heads";
            }
        }
        public void FlipCoinWeighted(int weight)
        {
            int randNum = rand.Next(100);
            if (randNum < weight)
            {
                sideUp = "Tails";
            }
            else 
            {
                sideUp = "Heads";
            }
        }
    }
}
