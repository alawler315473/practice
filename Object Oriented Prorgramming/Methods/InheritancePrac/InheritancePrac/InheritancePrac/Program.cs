using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program : Game
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            RTS rtsGame = new RTS("StarCraft");
            rtsGame.GitGud(player);
            rtsGame.GoToSleep(player);
            rtsGame.PracticeMicro(player);
            rtsGame.Play();

            FPS fpsGame = new FPS("Halo");
            fpsGame.GitGud(player);
            fpsGame.GoToSleep(player);
            fpsGame.PlayCampaign(player);
            fpsGame.PlayMultiplayer(player);
            fpsGame.Play();

            MOBA mobaGame = new MOBA("DOTA 2");
            mobaGame.GitGud(player);
            mobaGame.GoToSleep(player);
            mobaGame.PlaySolo(player);
            mobaGame.Play();

            RPG rpgGame = new RPG("Skyrim");
            rpgGame.GitGud(player);
            rpgGame.GoToSleep(player);
            rpgGame.PlayPvE(player);
            rpgGame.PlayPvP(player);
            rpgGame.Play();

            Console.WriteLine(player.skillLevel);
            Console.WriteLine(player.wellRestedPts);
        }
    }
}
