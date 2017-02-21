using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Desert:Area
    {
     

        public Desert()
        {
            type = "Desert";
            rand = new Random();
            monsterType = new List<string> { "Desert Eagle", "Clint Eastwood", "Cactus" };
        }

        public override Enemy EnemyEncounter()
        {
            int monsterIndex = rand.Next(3);
            int health = 0;
            int strength = 0;
            int defense = 0;

            if(monsterType[monsterIndex] == "Desert Eagle")
            {
                health = 60;
                strength = 100;
                defense = 25;
            }
            else if(monsterType[monsterIndex] == "Cactus")
            {
                health = 1000000;
                strength = 420;
                defense = 20000;
            }
            else if (monsterType[monsterIndex] == "Clint Eastwood")
            {
                health = 10;
                strength = 4;
                defense = 20;
            }
            return new Enemy(health, strength, defense, monsterType[monsterIndex]);
        }
    }
}

