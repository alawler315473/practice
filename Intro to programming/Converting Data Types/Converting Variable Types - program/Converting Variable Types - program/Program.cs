using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Variable_Types___program
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 123.3245;
            int myInt = 12;
            float myFloat = 19.6f;
            myDouble = myInt + .5;
            myInt = Convert.ToInt32(Math.Floor(myFloat));

            myInt = Convert.ToInt32(Math.Ceiling(myDouble));
            myDouble = myInt / 3;
            myDouble = 13.8;
            myFloat = 13.8f;
            myInt = Convert.ToInt32(myDouble + myFloat);
            myInt = Convert.ToInt32(Math.Ceiling(myDouble + myFloat));
        }
    }
}
