using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Entity
    {
        public int health;
        public int strength;
        public int defense;
        public string name;

        public void takeDamage(Entity entity)
        {
            health = (health - (entity.strength - entity.defense));
        }
    }
}
