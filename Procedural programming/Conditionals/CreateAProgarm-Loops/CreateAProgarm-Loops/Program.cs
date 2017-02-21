using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAProgarm_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int var1 = 1;
            while (var1 <= 100)
            {
                Console.WriteLine(var1);
                var1++;
            }
            Console.WriteLine();

            //2
            int var2 = 0;
            while (var2 <= 98)
            {
                var2 = var2 + 2;
                Console.WriteLine(var2);
            }
            Console.WriteLine();

            //3
            int i = 0;
            int j = 0;
            while (i <= 10)
            {
                Console.WriteLine("1");
                i = i + 3;
                Console.WriteLine(i);
                while (j <= 47)
                {
                    i = i + 2;
                    j = j + 1;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            //4
            int k = 0;
            while (k < 50)
            {
                k++;
                Console.WriteLine(k);
            }
            Console.WriteLine();

            //5
            int y = 50;
            while (y > 5)
            {
                Console.WriteLine(y);
                y--;
            }
            Console.WriteLine();

            //6
            int input1 = 0;
            int input2 = 0;
            Console.WriteLine("Enter a number: ");
            string var = Console.ReadLine();
            input1 = Convert.ToInt32(var);
            
            Console.WriteLine("Enter another number: ");
            string var5 = Console.ReadLine();
            input2 = Convert.ToInt32(var5);

            int e = 0;
            while (input2 < input1)
            {
                input2++;
                Console.WriteLine(input2);
            }
            while (input2 > input1)
            {
                input2--;
                Console.WriteLine(input2);
            }
            Console.WriteLine();

            //7
            int r = 0;

            while (r < 10)
            {
                r++;
                int t = 1;
                while (t < 11)
                {
                    Console.WriteLine(t);
                    t++;
                }
                Console.WriteLine("I counted to 10, " + r + " times.");
            }
            Console.WriteLine();

            //8
            int input10 = 0;
            int input20 = 0;
            Console.WriteLine("Enter a number: ");
            string var10 = Console.ReadLine();
            input10 = Convert.ToInt32(var10);

            Console.WriteLine("Enter another number: ");
            string var8 = Console.ReadLine();
            input20 = Convert.ToInt32(var8);

            
            while (input20 < input10)
            {
                input20++;
                if (input20 %3 == 0) {
                    Console.WriteLine(input20);
                }
            }
            while (input20 > input10)
            {
                input20--;
                if (input20 % 3 == 0) {
                    Console.WriteLine(input20);
                }
            }
            Console.WriteLine();
        }   
    }
}
