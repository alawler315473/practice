using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Monk : Player
    {
        public void Meditate()
        {
            magicPts = magicPts + (2 * magicAbility);
        }
    }
}
