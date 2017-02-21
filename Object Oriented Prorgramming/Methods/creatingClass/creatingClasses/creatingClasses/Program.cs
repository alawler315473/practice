using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin myCoin = new Coin();
            Random rand = new Random();
            myCoin.FlipCoinWeighted(rand.Next(100));
        }
    }
}
