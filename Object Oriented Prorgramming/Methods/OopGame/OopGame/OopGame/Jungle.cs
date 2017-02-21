using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Jungle:Area
    {
    

        public Jungle()
        {
            type = "Jungle";
            rand = new Random();
            monsterType = new List<string> { "Cougar", "Banana Salesmen", "Posion Dart Frog" };
        }

        public override Enemy EnemyEncounter()
        {
            int monsterIndex = rand.Next(3);
            int health = 0;
            int strength = 0;
            int defense = 0;

            if (monsterType[monsterIndex] == "Cougar")
            {
                health = 20;
                strength = 20000;
                defense = 40;
            }
            else if (monsterType[monsterIndex] == "Banana Salesmen")
            {
                health = 1000000;
                strength = 2;
                defense = 500000;
            }
            else if (monsterType[monsterIndex] == "Posin Dart Frog")
            {
                health = 5;
                strength = 12000000;
                defense = 5;
            }
            return new Enemy(health, strength, defense, monsterType[monsterIndex]);
        }
    }
}
