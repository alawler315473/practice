using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Frost:Area
    {
       

        public Frost()
        {
            type = "Frost";
            rand = new Random();
            monsterType = new List<string> { "Snowman", "Snowboarder", "Ice Dragon" };
        }

        public override Enemy EnemyEncounter()
        {
            int monsterIndex = rand.Next(3);
            int health = 0;
            int strength = 0;
            int defense = 0;

            if (monsterType[monsterIndex] == "Snowman")
            {
                health = 10000;
                strength = 10000;
                defense = 0;
            }
            else if (monsterType[monsterIndex] == "Snowboarder")
            {
                health = 20;
                strength = 0;
                defense = 10000;
            }
            else if (monsterType[monsterIndex] == "Ice Dragon")
            {
                health = 666666;
                strength = 666666;
                defense = 1;
            }
            return new Enemy(health, strength, defense, monsterType[monsterIndex]);
        }
    }
}
