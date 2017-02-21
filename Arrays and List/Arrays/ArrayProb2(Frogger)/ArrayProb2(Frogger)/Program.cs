using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ArrayProb2_Frogger_
{
    class Program
    {
        static void Main(string[] args)
        {

            //create an array that holds all the numbers
            //use a variable to tell whats negative and positive

            Console.Clear();
            int i = 0;
            int startingEnergy = 0;
            int currentEnergy = 0;
            int[] roadArray = new int[5];
            Console.WriteLine(" Enter the numbers: ");
            try
            {
                roadArray[0] = Convert.ToInt32(Console.ReadLine());
                roadArray[1] = Convert.ToInt32(Console.ReadLine());
                roadArray[2] = Convert.ToInt32(Console.ReadLine());
                roadArray[3] = Convert.ToInt32(Console.ReadLine());
                roadArray[4] = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" Wrong Format, try again");
                Thread.Sleep(1000);
                Main(args);
            }
            while (i < roadArray.Length)
            {
                currentEnergy = currentEnergy + roadArray[i];
                if (currentEnergy < 0)
                {
                    if (startingEnergy < -currentEnergy)
                    {
                        startingEnergy = -currentEnergy;
                    }
                }
                i++;
            }
            Console.WriteLine(startingEnergy);
        }
    }
}
