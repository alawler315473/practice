using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Warrior : Player
    {
        public void Attack(Player player,Warrior warrior)
        {
            warrior.attack = 0;
            player.health = (player.health - warrior.attack);
        }
    }
}
