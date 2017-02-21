using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InheritancePrac
{
    class Game
    {
        public int difficulty;
        public int gameComplexity;
        public string name;

        public void Play()
        {
            Console.WriteLine("Loading...");
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to..." + name);
            Thread.Sleep(1000);
        }

        public void GitGud(Player player)
        {
            player.skillLevel = (player.skillLevel + difficulty);
            player.wellRestedPts = (player.wellRestedPts - gameComplexity);
        }

        public void GoToSleep(Player player)
        {
            player.wellRestedPts = (player.wellRestedPts + 10);
        }
    }
}
