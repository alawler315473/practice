using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers___Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            double num1 = 0;

            Console.WriteLine(" Enter a number: ");
            string var1 = Console.ReadLine();
            num1 = Convert.ToDouble(var1);



           
            while (num1 > 1)
            {
                bool prime = true;
                int k = 2;

                while (k < num1)
                {
                    if (num1 % k == 0)
                    {
                        prime = false;
                    }
                    k++;
                }
                if (prime == true)
                {
                    Console.WriteLine(num1);
                }
                num1--;
            }
        }
    }
}
