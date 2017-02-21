using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class RTS : Game
    {
        public RTS(string Name)
        {
            difficulty = 3;
            gameComplexity = 5;
            name = Name;
        }
        public void PracticeMicro(Player player)
        {
            player.skillLevel++;
            player.wellRestedPts = player.wellRestedPts - 3;
        }
    }
}
