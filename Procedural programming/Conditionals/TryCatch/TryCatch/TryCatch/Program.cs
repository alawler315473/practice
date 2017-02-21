using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //add all try catch blocks so that the program will not crash on any bad inputs
            //use separate try catch for each conversion.
            while (true)
            {
                try
                {
                    Console.WriteLine("enter a number");
                    int myInt = Convert.ToInt32(Console.ReadLine());
                    if (myInt == 55)
                    {
                        Console.WriteLine("youWin");
                        break;
                    }
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(" Number is to large ");
                    continue;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(" Wrong format");
                    continue;
                }
                break;           
            }




            while (true)
            {
                try
                {
                    Console.WriteLine("guess a letter");
                    char myChar = Convert.ToChar(Console.ReadLine());
                    if (myChar == 'k')
                    {
                        Console.WriteLine("youWin");
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Wrong word format");
                    continue;
                }
                break;
            }




            while (true)
            {
                try
                {
                    Console.WriteLine("enter a number");
                    int myInt1;
                    while (true)
                    {
                        myInt1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    int myInt2;
                    while (true)
                    {
                        myInt2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    if (myInt1 == 12 && myInt2 == 43)
                    {
                        Console.WriteLine("youWin");
                        break;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine(" Too long, chill out with that ");
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Wrong Format ");
                }
                break;
            }
        }
    }
}
