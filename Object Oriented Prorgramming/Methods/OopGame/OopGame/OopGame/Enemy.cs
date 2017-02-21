using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Enemy:Entity
    { 
        public Enemy(int Health, int Strength, int Defense, string Name)
        {
            health = Health;
            strength = Strength;
            defense = Defense;
            name = Name;
        }

        public void takeDamage(Character character)
        {
            health = (health - (character.strength - character.defense));
        }
    }
}
