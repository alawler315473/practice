using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Plains:Area
    {
        string type;
        List<string> monsterType;
        public Random rand;

        public Plains()
        {
            type = "Plains";
            rand = new Random();
            monsterType = new List<string> { "Cow", "Horse with Rockets", "Wheat Grass" };
        }
        public Enemy EnemyEncounter()
        {
            int monsterIndex = rand.Next(3);
            int health = 0;
            int strength = 0;
            int defense = 0;

            if (monsterType[monsterIndex] == "Cow")
            {
                health = 10;
                strength = 2000;
                defense = 60000;
            }
            else if (monsterType[monsterIndex] == "Horse with Rockets")
            {
                health = 400;
                strength = 10000;
                defense = 20000;
            }
            else if (monsterType[monsterIndex] == "Wheat Grass")
            {
                health = 20000000;
                strength = 1000000;
                defense = 10;
            }
            return new Enemy(health, strength, defense, monsterType[monsterIndex]);
        }
    }
}
