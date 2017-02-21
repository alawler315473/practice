using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Rouge : Player
    {
        public void Rest()
        {
            actionPts = actionPts + (2 * attack);
        }
    }
}
