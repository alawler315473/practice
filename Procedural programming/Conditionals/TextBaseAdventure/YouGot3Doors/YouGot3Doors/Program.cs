using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace YouGot3Doors
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerInput;
            while (true)
            {
                bool correct = true;

                //1
                while (correct)
                {

                    Console.Clear();
                    Console.WriteLine(" 1. Hello player, please choose a door. If you choose the wrong door, you start all over. \n");

                    Console.WriteLine("  ____     ____     ____   ");
                    Console.WriteLine(" |    |   |    |   |    |  ");
                    Console.WriteLine(" |o   |   |o   |   |o   |  ");
                    Console.WriteLine(" |    |   |    |   |    |  ");
                    Console.WriteLine(" |____|   |____|   |____|  ");
                    Console.WriteLine("\n   1        2        3    \n\n ");
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        
                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        Console.WriteLine();
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while
               
                



                //2
                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 2. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____        ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |       ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |       ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |       ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|       ");
                    Console.WriteLine("\n   1        2        3        4     \n\n ");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        Console.WriteLine();
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while



                //3
                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 3. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____     ____  ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    | ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |   |o   | ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    | ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|   |____| ");
                    Console.WriteLine("\n   1        2        3        4        5  \n\n    ");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        Console.WriteLine();
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while


                
                //4
                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 4. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____     ____     ____       ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |      ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |   |o   |   |o   |      ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |      ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|   |____|   |____|      ");
                    Console.WriteLine("\n   1        2        3        4        5        6         \n\n");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        Console.WriteLine();
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while




                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 5. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____     ____     ____     ____      ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |     ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |     ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |     ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|   |____|   |____|   |____|     ");
                    Console.WriteLine("\n   1        2        3        4        5        6        7    \n\n");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while



                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 6. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____     ____     ____     ____     ____          ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |   |    |         ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |         ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |   |    |         ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|   |____|   |____|   |____|   |____|         ");
                    Console.WriteLine("\n   1        2        3        4        5        6        7        8      \n\n");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 7)
                    {
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while
                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 7. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____     ____     ____     ____     ____        ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |   |    |       ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |       ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |   |    |       ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|   |____|   |____|   |____|   |____|       ");
                    Console.WriteLine("\n   1        2        3        4        5        6        7        8        ");
                    Console.WriteLine("  ____           ");
                    Console.WriteLine(" |    |          ");
                    Console.WriteLine(" |o   |          ");
                    Console.WriteLine(" |    |          ");
                    Console.WriteLine(" |____|          ");
                    Console.WriteLine("\n  9        \n\n");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while

                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" 8. Pick a door :) \n\n");

                    Console.WriteLine("  ____     ____     ____     ____     ____     ____     ____     ____        ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |   |    |       ");
                    Console.WriteLine(" |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |   |o   |       ");
                    Console.WriteLine(" |    |   |    |   |    |   |    |   |    |   |    |   |    |   |    |       ");
                    Console.WriteLine(" |____|   |____|   |____|   |____|   |____|   |____|   |____|   |____|       ");
                    Console.WriteLine("\n   1        2        3        4        5        6        7        8        ");
                    Console.WriteLine("  ____     ____        ");
                    Console.WriteLine(" |    |   |    |       ");
                    Console.WriteLine(" |o   |   |o   |       ");
                    Console.WriteLine(" |    |   |    |       ");
                    Console.WriteLine(" |____|   |____|       ");
                    Console.WriteLine("\n  9        10       \n\n");
                    Console.WriteLine();
                    try
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(" wrong format, try again");
                        Thread.Sleep(1000);
                        continue;
                    }
                    if (playerInput == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Job you choose the correct door");
                        correct = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" You choose the wrong door, you suck.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        correct = false;
                        break;
                    }
                }//while

                while (correct)
                {
                    Console.Clear();
                    Console.WriteLine(" Wow, you made it this far, how much spare time do you have?");
                    Thread.Sleep(2000);
                    Console.WriteLine(" You beat my game. GG. ");
                    Thread.Sleep(2000);
                    break;
                }
            }
        }
    }
}