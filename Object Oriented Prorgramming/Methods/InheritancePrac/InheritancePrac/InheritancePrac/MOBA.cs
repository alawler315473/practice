using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class MOBA : Game
    {
        public MOBA(string Name)
        {
            name = Name;
            difficulty = 2;
            gameComplexity = 4;
        }
        public void PlaySolo(Player player)
        {
            player.skillLevel = player.skillLevel + 1;
            player.wellRestedPts = (player.wellRestedPts - 3);
        }
        public void PlayArranged(Player player)
        {
            player.skillLevel = (player.skillLevel + 2);
            player.wellRestedPts = (player.wellRestedPts - 5);
        }
    }
}
