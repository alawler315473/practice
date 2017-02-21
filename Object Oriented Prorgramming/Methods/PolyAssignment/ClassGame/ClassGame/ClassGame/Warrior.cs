using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Warrior : Player
    {
        public Warrior(int health,int attack,int magicPts, int magicAbility, int actionPts)
            :base(health,attack,magicPts,magicAbility,actionPts)
		{
		
		}
        public override bool Attack(Player player)
        {
            if (actionPts > 10)
            {
                player.TakeDamage(attack);
                actionPts -= 10;
                return true;
            }
            return false;
        }
    }
}
