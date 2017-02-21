using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character newCharacter = new Character(100,50,100,"jhuh");
            Random num = new Random();
            long xp;
            List<string> promptList = new List<string>();
            promptList.Add("You found a rusty sword but decided not to pick it up because you can not remember when you had your last tetnus shot.");

            Area newArea;
            newArea = new Jungle();

            while (true)
            {
                int myNumm = num.Next(0, 5);
                if(myNumm <= 3)
                {
                    Enemy enemy = newArea.EnemyEncounter();
                    Console.WriteLine("You've encountered"+enemy.name);
                    while(enemy.health >= 0)
                    {
                        
                    }
                }
            }
        }
    }
}
