using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class FPS : Game
    {
        public FPS(string Name)
        {
            name = Name;
            difficulty = 2;
            gameComplexity = 4;
        }
        public void PlayCampaign(Player player)
        {
            player.wellRestedPts = player.wellRestedPts - 1;
        }
        public void PlayMultiplayer(Player player)
        {
            player.skillLevel++;
            player.wellRestedPts = player.wellRestedPts - 2;
        }
    }
}
