using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Mage : Player
    {
        public void Fireball(Player player)
        {
            player.health = Convert.ToInt32((player.health - 1.5 * magicAbility));
            player.actionPts = player.actionPts - 10;
        }
    }
}
