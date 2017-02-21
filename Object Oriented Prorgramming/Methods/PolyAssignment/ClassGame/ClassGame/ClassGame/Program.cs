using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player currentPlayer;
            Player otherPlayer;
            currentPlayer = CreatePlayer(1);
            otherPlayer = CreatePlayer(2);
            bool player1Turn = true;

            while (currentPlayer.IsAlive())
            {
                while (true)
                {
                    if (player1Turn)
                    {
                        Console.WriteLine("Player1 choose an action.");
                    }
                    else
                    {
                        Console.WriteLine("player2 choose an action");
                    }
                    Console.WriteLine("choose an action");
                    Console.WriteLine("attack");
                    Console.WriteLine("fireball");
                    Console.WriteLine("rest");
                    Console.WriteLine("heal");
                    Console.WriteLine("meditate");
                    string action = Console.ReadLine().ToLower();
                    if (action == "attack")
                    {
                        if (currentPlayer.Attack(otherPlayer)) { break; }
                        Console.WriteLine("not enough magicPts or Action points to do this action");
                    }
                    else if (action == "fireball")
                    {
                        if (currentPlayer.Fireball(otherPlayer)) { break; }
                        Console.WriteLine("not enough magicPts or Action points to do this action");
                    }
                    else if (action == "rest")
                    {
                        if (currentPlayer.Rest()) { break; }
                        Console.WriteLine("not enough magicPts or Action points to do this action");
                    }
                    else if (action == "heal")
                    {
                        if (currentPlayer.Rest()) { break; }
                        Console.WriteLine("not enough magicPts or Action points to do this action");
                    }
                    else if (action == "meditate")
                    {
                        if (currentPlayer.Meditate()) { break; }
                        Console.WriteLine("not enough magicPts or Action points to do this action");
                    }
                    else
                    {
                        Console.WriteLine("unrecognized action please try again");
                    }
                }
                Player tempPlayer;
                tempPlayer = otherPlayer;
                otherPlayer = currentPlayer;
                currentPlayer = tempPlayer;
                player1Turn = !player1Turn;
            }
            if (player1Turn)
            {
                Console.WriteLine("player2 wins");
            }
            else
            {
                Console.WriteLine("player1 wins");
            }
            Console.ReadKey();
            
        }

        static Player CreatePlayer(int playerNumber)
        {
            Player newPlayer;
            List<int> statsList = new List<int>();
            Console.WriteLine("Player" + playerNumber+" choose a class");
            while (true)
            {
                Console.WriteLine("mage, medic, warrior, rogue, or monk");
                string playerClass = Console.ReadLine().ToLower();
                if (playerClass == "mage")
                {
                    statsList = getStats();
                    newPlayer = new Mage(statsList[0] * 5, statsList[1], statsList[2], statsList[3] * 5, statsList[4] * 5);
                    break;
                }
                else if (playerClass == "medic")
                {
                    statsList = getStats();
                    newPlayer = new Medic(statsList[0] * 5, statsList[1], statsList[2], statsList[3] * 5, statsList[4] * 5);
                    break;
                }
                else if (playerClass == "warrior")
                {
                    statsList = getStats();
                    newPlayer = new Warrior(statsList[0] * 5, statsList[1], statsList[2], statsList[3] * 5, statsList[4] * 5);
                    break;
                }
                else if (playerClass == "rogue")
                {
                    statsList = getStats();
                    newPlayer = new Rogue(statsList[0] * 5, statsList[1], statsList[2], statsList[3] * 5, statsList[4] * 5);
                    break;
                }
                else if (playerClass == "monk")
                {
                    statsList = getStats();
                    newPlayer = new Monk(statsList[0] * 5, statsList[1], statsList[2], statsList[3] * 5, statsList[4] * 5);
                    break;
                }
                else
                {
                    Console.WriteLine("unrecognized class please try again");
                }
            }
            return newPlayer;
        }
        static List<int> getStats()
        {
            List<int> statsList = new List<int>();
            int statTotal = 0;
            while(statTotal != 60)
            {
                statTotal = 0;
                statsList.Clear();
                Console.WriteLine("set skill points for character(must total 60)");
                Console.WriteLine("health (5hp per skill pt.)");
                Console.WriteLine("attack");
                Console.WriteLine("magicAbility");
                Console.WriteLine("magicPts(5mp per skill pt.)");
                Console.WriteLine("actionPts(5ap per skill pt.)");
                Console.WriteLine("enter skill pts dedicated to health:");
                int health = Convert.ToInt32(Console.ReadLine());
                statsList.Add(health);
                statTotal += health;
                Console.WriteLine("enter skill pts dedicated to attack:");
                int attack = Convert.ToInt32(Console.ReadLine());
                statsList.Add(attack);
                statTotal += attack;
                Console.WriteLine("enter skill pts dedicated to magicAbility:");
                int magicAbility = Convert.ToInt32(Console.ReadLine());
                statsList.Add(magicAbility);
                statTotal += magicAbility;
                Console.WriteLine("enter skill pts dedicated to magicPts:");
                int magicPts = Convert.ToInt32(Console.ReadLine());
                statsList.Add(magicPts);
                statTotal += magicPts;
                Console.WriteLine("enter skill pts dedicated to actionPts:");
                int actionPts = Convert.ToInt32(Console.ReadLine());
                statsList.Add(actionPts);
                statTotal += actionPts;
            }
            return statsList;

        }
    }
}
