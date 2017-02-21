using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter a number");
            string input = Console.ReadLine();
            int score1 = Convert.ToInt32(input);
            if (score1 > 93)
            {
                Console.WriteLine("You got an A, congrats dude!");
            }
            else if (score1 > 90)
            {
                Console.WriteLine("You got an A-");
            }
            else if (score1 > 87)
            {
                Console.WriteLine("You got a B+");
            }
            else if (score1 > 83)
            {
                Console.WriteLine("You got a B");
            }
            else if (score1 > 80)
            {
                Console.WriteLine("You got a B");
            }
            else if (score1 > 77)
            {
                Console.WriteLine("You get a C+");
            }
            else if (score1 > 73)
            {
                Console.WriteLine("You got a C");
            }
            else if (score1 > 70)
            {
                Console.WriteLine("You got a C-");
            }
            else if (score1 > 67)
            {
                Console.WriteLine("you got a D+");
            }
            else if (score1 > 63)
            {
                Console.WriteLine("You got a D");
            }
            else if (score1 > 60)
            {
                Console.WriteLine("You got a D-");
            }
            else if (score1 < 60)
            {
                Console.WriteLine("You suck, you got an E");
            }
        }
    }
}
