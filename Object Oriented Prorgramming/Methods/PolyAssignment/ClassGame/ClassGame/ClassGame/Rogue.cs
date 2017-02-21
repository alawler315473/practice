using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Rogue:Player
    {
        public Rogue(int health,int attack,int magicPts, int magicAbility, int actionPts)
            :base(health,attack,magicPts,magicAbility,actionPts)
		{
		
		}
        public override bool Rest()
        {
            actionPts += 2*attack;
            return true;
        }
    }
}
