using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class RPG : Game
    {
        public RPG(string Name)
        {
            name = Name;
            difficulty = 1;
            gameComplexity = 3;
        }
        public void PlayPvE(Player player)
        {
            player.wellRestedPts = player.wellRestedPts - 5;
        }
        public void PlayPvP(Player player)
        {
            player.skillLevel = player.skillLevel + 1;   
            player.wellRestedPts = player.wellRestedPts - 4;
        }
    }
}
