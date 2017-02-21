using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Mage:Player
    {
         public Mage(int health,int attack,int magicPts, int magicAbility, int actionPts)
            :base(health,attack,magicPts,magicAbility,actionPts)
		{
		    
		}
        public override bool Fireball(Player player)
        {
            if (magicPts > 20)
            {
                player.TakeDamage(Convert.ToInt32(1.5*magicAbility));
                magicPts -= 20;
                return true;
            }
            return false;
        }
    }
}
