using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Character:Entity
    {
        public Character(int Health, int Strength, int Defense, string Name)
        {
            health = Health;
            strength = Strength;
            defense = Defense;
            name = Name;
        }
    }
}
