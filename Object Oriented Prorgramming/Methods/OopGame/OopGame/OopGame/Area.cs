using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    public class Area
    {
        protected string type;
        protected List<string> monsterType;
        public Random rand;

        public virtual Enemy EnemyEncounter()
        {
            return new Enemy(0, 0, 0, null);
                
        }
}
