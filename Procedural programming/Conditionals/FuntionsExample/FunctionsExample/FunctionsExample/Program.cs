using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = GetInput("Enter a number ");
            var1 = GetInput("Enter a number ");
        }

        //other functions
        static int GetInput(string promptString)
        {
            int inputNumber;
            {
                while (true)
                {
                    Console.WriteLine(promptString);
                    try
                    {
                        inputNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(" Format error, Try again ");
                        Console.Clear();
                    }
                }
                return inputNumber;
            }
        }
    }
}