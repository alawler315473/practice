using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfIntroToProgramming___assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1 = 9;
            double var2 = 4.7;
            string var3 = "74";
            string var4 = "U";
            double var5 = (Convert.ToDouble(var1));
            var5 = var1 + var2;
            Console.WriteLine("var5: "+var5);
            int myInt = Convert.ToInt32(Math.Floor(var5));
            Console.WriteLine("myInt: "+myInt);
            var2 = var2 - 1;
            myInt = 133;
            Console.WriteLine("myInt: "+myInt);
            var2 = var2 - 1;
            string var6 = "213374U";
            Console.WriteLine("Hi, enter ur name below plz ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ", I'm " + var6+".");

        }
    }
}
