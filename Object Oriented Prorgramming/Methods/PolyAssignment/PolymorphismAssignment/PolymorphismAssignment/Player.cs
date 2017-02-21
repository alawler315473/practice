using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Player
    {
        public int health;
        public int playerAttack;
        public int magicAbility;
        public int maxHealth;
        public int magicPts;
        public int actionPts;
        public int attack;

        public Player()
        {
            health = 100;
            playerAttack = 0;
            magicAbility = 0;
            maxHealth = 100;
            magicPts = 100;
            actionPts = 100;
            attack = 0;
        }
    }
}
