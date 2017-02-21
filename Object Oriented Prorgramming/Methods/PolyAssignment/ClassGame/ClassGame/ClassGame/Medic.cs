using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Medic:Player
    {
         public Medic(int health,int attack,int magicPts, int magicAbility, int actionPts)
            :base(health,attack,magicPts,magicAbility,actionPts)
		{
		
		}
        public override bool Heal()
        {
            if (magicPts > 10)
            {
                health = (2/maxHealth * magicAbility);
                if (health > maxHealth)
                {
                    health = maxHealth;
                }
                magicPts -= 10;
                return true;
            }
            return false;
        }
    }
}
