using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon1 = new Dragon();
            Dragon dragon2 = new Dragon(false,true,"purple",7000);
            dragon1.Attack(dragon2);
            dragon2.Attack(dragon1);

            Console.WriteLine("dragon1 health: " + dragon1.health);
            Console.WriteLine("dragon2 health: " + dragon2.health);
            Console.ReadKey();
        }
    }
}
