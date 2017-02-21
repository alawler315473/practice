using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;

            Console.WriteLine();
            Console.WriteLine("Enter 4 numbers and I'll calculate the average, promise...");
            Console.WriteLine();
            Console.WriteLine("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            string str2 = Console.ReadLine();
            double num2 = Convert.ToDouble(str2);

            Console.WriteLine("Enter number 3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 4: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            average = (num1 + num2 + num3 + num4);
            average = average / 4;
            Console.WriteLine("Your average is: " + average +" ,told ya so.");

        }
    }
}
