using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Enter test score 1: ");
            double test1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter test score 2: ");
            double test2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter test score 3: ");
            double test3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            TestAvg(test1, test2, test3);
        }

        static double TestAvg(double test1, double test2, double test3)
        {
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();

            double average = test1 + test2 + test3;
            average = average / 3;
            Console.WriteLine("Hello, "+name+" Your average is: " + average);
            return average;
        }
    }
}
