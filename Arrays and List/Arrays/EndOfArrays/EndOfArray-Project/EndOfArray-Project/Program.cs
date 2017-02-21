using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EndOfArray_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = new string[2];
            int[] assignmentsArray = new int[3];
            int[][] scoreArray = new int[3][];

            // loop 4 getting info  
            Console.Clear();        
            for (int k = 0; k < namesArray.Length; k++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the students name:");
                namesArray[k] = Console.ReadLine();
                Console.WriteLine();
              
                for (int x = 0; x < assignmentsArray.Length; x++)
                {
                    Console.WriteLine("Enter their assinment score: ");
                    assignmentsArray[x] = Convert.ToInt32(Console.ReadLine());
                }
                scoreArray[k] = assignmentsArray;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Enter a name for grading stuff: ");
            string inputName = Console.ReadLine();
            double studentAverage = 0;
            int holdNumbers = 0;

            for (int a = 0; a < namesArray.Length; a++)
            {
                if(inputName == namesArray[a])
                {
                    for (int k = 0; k < scoreArray[a].Length; k++) {
                        holdNumbers = holdNumbers + scoreArray[a][k];
                    }
                }
            }
            studentAverage = holdNumbers / Convert.ToDouble(assignmentsArray.Length);
            Console.WriteLine("Your average is: "+studentAverage);
            Console.WriteLine(" To enter more names, type return");
            string playerInput = Console.ReadLine();
            if(playerInput == "return")
            {
                Main(args);
            }         
        } 
    }
}
