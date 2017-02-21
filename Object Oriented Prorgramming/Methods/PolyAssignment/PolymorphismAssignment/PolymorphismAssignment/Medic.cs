using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Medic : Player
    {
        public void Heal()
        {
            health = (2 / maxHealth) * magicAbility;
            magicPts = magicPts - 2;
        }
    }
}
