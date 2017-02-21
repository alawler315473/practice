using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Solving_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number: ");
            try
            {
                Console.Clear();
                //get input, and put it into the array.
                //Thought Procces: I'm using a group of numbers the user puts in,
                //and seeing if the last output matches any of the other inputs.
                int[] playerInputArray = new int[5];
                Console.WriteLine(" Enter a number: ");
                playerInputArray[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter a number: ");
                playerInputArray[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter a number: ");
                playerInputArray[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter a number: ");
                playerInputArray[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter a number: ");
                playerInputArray[4] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\n Enter another number: ");
                int playerInput = Convert.ToInt32(Console.ReadLine());

                //check if input matches any  element in array
                if (playerInput == playerInputArray[0] || playerInput == playerInputArray[1] || playerInput == playerInputArray[2] || playerInput == playerInputArray[3] || playerInput == playerInputArray[4] || playerInput == playerInputArray[5])
                {
                    Console.WriteLine(" your number matches the element! ");
                }
                else if(playerInput != playerInputArray[0] || playerInput != playerInputArray[1] || playerInput != playerInputArray[2] || playerInput != playerInputArray[3] || playerInput != playerInputArray[4] || playerInput != playerInputArray[5] )
                {
                    Console.WriteLine(" your number did not match the element. ");
                }
            }
            //catch statement
            catch(FormatException ex)
            {
                Console.WriteLine(" wrong format, try again");
                Thread.Sleep(1000);
                Main(args);
            }
            //problem 2 solving

            /* 1) FirstI would see how I can get the the player input functioning
             * 2) Then I would try and see if I can get a way of showing an ouput the matches the pattern
             * 2) Then If nothing else works then I would attempt to found out if I can somehow run a function
             * that would correspond with the pattern.
            */
        }
    }
}
