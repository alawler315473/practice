using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Monk : Player
    {
       public Monk(int health,int attack,int magicPts, int magicAbility, int actionPts)
            :base(health,attack,magicPts,magicAbility,actionPts)
		{
		
		}
        public override bool Meditate()
        {
            if (actionPts > 5)
            {
                magicPts =+ 2*magicAbility;
                actionPts -= 5;
                return true;
            }
            return false;
        }
    }
}
