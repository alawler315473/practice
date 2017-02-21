using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Escape_The_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int keys = 0;
            //start of the game.
            Console.WriteLine("Hello, your in a spooky house and probably want out...");
            Thread.Sleep(2000);
            Console.WriteLine("Find a way out or else...\n\n\n\n\n");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine();
            FirstRoom(ref keys);
        }

        //the game giving you the options.
        static void FirstRoom(ref int keys)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("          \\                                                /");
                Console.WriteLine("            \\____________________________________________/");
                Console.WriteLine("             |                                          |");
                Console.WriteLine("             |      2 _____     1 ____                  |");
                Console.WriteLine("             |       |__|__|     |    |       3 -->     |");
                Console.WriteLine("             |       |__|__|     |   o|                 |");
                Console.WriteLine("             |___________________|____|_________________|");
                Console.WriteLine("            /                                            \\");
                Console.WriteLine("          /                                                \\\n\n");
                Console.WriteLine(" Pick any of the pathway options \n");
                Console.WriteLine(" 1) Door \n 2) Window \n 3) Turn around \n");
                string playerInput = Console.ReadLine();
                FirstRoomDecsion(playerInput, ref keys);

                if (playerInput == "1" || playerInput == "2" || playerInput == "3")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("bad input, try again");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        //The player deciding what path to choose.       
        static void FirstRoomDecsion(string playerInput, ref int keys)
        {
            //door pathway
            if (playerInput == "1")
            {
                Console.Clear();
                Console.WriteLine("        ____     ");
                Console.WriteLine("       |    |   ");
                Console.WriteLine("       |   o|   ");
                Console.WriteLine("   ____|____|___\n\n");

                if (keys < 1)
                {
                    Console.WriteLine(" the Door is locked, type (r), to return back to your intial postion\n\n ");
                    playerInput = Console.ReadLine();

                    if (playerInput == "r")
                    {
                        Console.Clear();
                        FirstRoom(ref keys);
                    }
                }
                else if (keys == 1)
                {
                    Console.Clear();
                    Console.WriteLine("        ____     ");
                    Console.WriteLine("       |    |   ");
                    Console.WriteLine("       |   o|   ");
                    Console.WriteLine("   ____|____|___\n\n");
                    Console.WriteLine(" the Door is locked, type (r), to return back to your intial postion ");
                    Console.WriteLine(" If you have a key, type (u) to unlock the door \n\n");
                    playerInput = Console.ReadLine();
                    if (playerInput == "u")
                    {
                        Console.Clear();
                        LeavingRoom(ref keys, playerInput);
                    }
                    else if (playerInput == "r")
                    {
                        Console.Clear();
                        FirstRoom(ref keys);
                    }
                }
            }

            //stupid stuff at the window pathway
            else if (playerInput == "2")
            {
                Console.Clear();
                Console.WriteLine("           _____            ");
                Console.WriteLine("          |__|__|           ");
                Console.WriteLine("          |__|__|            ");
                Console.WriteLine("      _______________       \n\n");
                Console.WriteLine(" Its quite dark out, the window is locked. what do you do?\n ");
                Console.WriteLine(" (1) Punch it or (r) return back like a smart person. \n");
                playerInput = Console.ReadLine();
                if (playerInput == "r")
                {
                    Console.Clear();
                    FirstRoom(ref keys);
                }
                else if (playerInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine(" You just hurt your hand and the window is still unbroken..");
                    Console.WriteLine(" Just return back dummie by pressing (r) \n\n");
                    playerInput = Console.ReadLine();
                    if (playerInput == "r")
                    {
                        Console.Clear();
                        FirstRoom(ref keys);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Your dumb. your going back anyways.\n\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        FirstRoom(ref keys);
                    }
                }
            }

            //finding the key pathway
            else if (playerInput == "3")
            {
                Console.Clear();
                Console.WriteLine("                       ");
                Console.WriteLine("           _____         ");
                Console.WriteLine("          |_~_~_|            ");
                Console.WriteLine("      ____|_~_~_|______       \n\n");
                Console.WriteLine(" You see a small dresser along side one of the walls. type (o) \n to open the drawer \n\n");
                playerInput = Console.ReadLine();
                if (playerInput == "o")
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("            {|          ");
                    Console.WriteLine("            {|         ");
                    Console.WriteLine("           [_]      \n\n");
                    Console.WriteLine(" It appears to be a key, used for a door. ");
                    Console.WriteLine(" Type in (r) to return back to your intial postion. \n\n ");
                    keys = 0;
                    playerInput = Console.ReadLine();
                    if (playerInput == "r")
                    {
                        keys++;
                        Console.Clear();
                        FirstRoom(ref keys);
                    }
                }
            }
        }

        // LeavingTheRoom();
        static void LeavingRoom(ref int keys, string playerInput)
        {
            Console.Clear();
            Console.WriteLine("       ____ ____     ");
            Console.WriteLine("      |    |    |   ");
            Console.WriteLine("      |    |    |   ");
            Console.WriteLine("   ___|____|____|___\n\n");
            Console.WriteLine(" The door has opened, enter the hallway (1) or try the window again (2) \n\n ");
            playerInput = Console.ReadLine();
            if (playerInput == "1")
            {
                Console.WriteLine("Awesome, now ur outside the room.");
                Hallway(ref keys, playerInput);
            }
            else
            {
                FirstRoomDecsion(playerInput, ref keys);
            }
        }



        //Hallway
        static void Hallway(ref int keys, string playerInput)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n");
                Console.WriteLine("      \\                       / ");
                Console.WriteLine("        \\                   /   ");
                Console.WriteLine("          \\               /     ");
                Console.WriteLine("            \\           /       ");
                Console.WriteLine("              \\ ______/         ");
                Console.WriteLine("         1| \\  |2 __  |  / |3     ");
                Console.WriteLine("          |  | | | .| | |  |     ");
                Console.WriteLine("          | o| |_|__|_| | o|     ");
                Console.WriteLine("          |  | /       \\|  |     ");
                Console.WriteLine("          |  /           \\ |     ");
                Console.WriteLine("          |/               \\    ");
                Console.WriteLine("         /            4) -o  \\  ");
                Console.WriteLine("       /                       \\\n");

                Console.WriteLine(" You are now in the Hallway, \n choose one of the actions below. \n");
                Console.WriteLine(" 1) Door1 \n 2) Door2 \n 3) Door3 \n 4) Examine the object on the ground \n");
                playerInput = Console.ReadLine();
                if (playerInput == "1" || playerInput == "2" || playerInput == "3" || playerInput == "4")
                {
                    break;
                }
                Console.WriteLine("bad input try again");
                Thread.Sleep(1);
            }
            HallwayDecison(ref keys, playerInput);

        }
        static void HallwayDecison(ref int keys, string playerInput)
        {
            if (playerInput == "1")
            {
                Console.Clear();
                Console.WriteLine("        ____         ");
                Console.WriteLine("       |    |   ");
                Console.WriteLine("       |   o|   ");
                Console.WriteLine("   ____|____|___\n\n");
                Console.WriteLine(" The door is locked, type (r) to return. \n\n");
                playerInput = Console.ReadLine();
                if (playerInput == "r")
                {
                    Console.Clear();
                    Hallway(ref keys, playerInput);
                }
            }
            else if (playerInput == "2")
            {
                Console.Clear();
                Console.WriteLine("        ____         ");
                Console.WriteLine("       |    |   ");
                Console.WriteLine("       |   o|   ");
                Console.WriteLine("   ____|____|___\n\n");
                Console.WriteLine(" The door is locked, type (r) to return. \n\n");
                playerInput = Console.ReadLine();
                if (playerInput == "r")
                {
                    Console.Clear();
                    Hallway(ref keys, playerInput);
                }
            }
            else if (playerInput == "3")
            {
                Console.Clear();
                Console.WriteLine("        ____          ");
                Console.WriteLine("       |    |   ");
                Console.WriteLine("       |   o|   ");
                Console.WriteLine("   ____|____|___\n\n");
                Console.WriteLine(" The door is locked, type (r) to return. \n\n");
                playerInput = Console.ReadLine();
                if (playerInput == "r")
                {
                    Console.Clear();
                    Hallway(ref keys, playerInput);
                }
            }
            else if (playerInput == "4")
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("            {|          ");
                Console.WriteLine("            {|         ");
                Console.WriteLine("           [_]      \n\n");
                Console.WriteLine(" Another key, this must be the way out? \n type (gr) to grab the key and return back to your \n initial postion. \n\n");
                playerInput = Console.ReadLine();
                if (playerInput == "gr")
                {
                    Console.Clear();
                    HallwayEndGame(keys, playerInput);
                }
            }
        }

        static void HallwayEndGame(int keys, string playerInput)
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("   You have 3 choices at unlocking the right door... ");
            Thread.Sleep(2000);
            Console.WriteLine("   The right door chooses your fate...");
            Thread.Sleep(2000);
            Console.WriteLine("   Which ever door you unlock, you'll escape this house...");
            Thread.Sleep(2000);
            Console.WriteLine("   But if you choose the wrong door, you will die and start all over again...");
            Thread.Sleep(2000);
            Console.WriteLine("   Your choice will decide your fate... \n\n");
            Thread.Sleep(2000);
            Console.WriteLine("   Have Fun!!");
            Thread.Sleep(3000);
            Console.Clear();

            while (true)
            {
                //EndGame choose door

                Console.WriteLine("\n\n");
                Console.WriteLine("      \\                       /      ");
                Console.WriteLine("        \\                   /   ");
                Console.WriteLine("          \\               /     ");
                Console.WriteLine("            \\           /       ");
                Console.WriteLine("              \\ ______/         ");
                Console.WriteLine("         1| \\  |2 __  |  / |3     ");
                Console.WriteLine("          |  | | | .| | |  |     ");
                Console.WriteLine("          | o| |_|__|_| | o|     ");
                Console.WriteLine("          |  | /       \\|  |     ");
                Console.WriteLine("          |  /           \\ |     ");
                Console.WriteLine("          |/               \\    ");
                Console.WriteLine("         /                   \\  ");
                Console.WriteLine("       /                       \\\n\n");

                Console.WriteLine(" Choose one of the doors below. \n");
                Console.WriteLine(" 1) Door1 \n 2) Door2 \n 3) Door3 \n");
                playerInput = Console.ReadLine();

                EndGameDecsion(keys,playerInput);

                if(playerInput == "1" || playerInput == "2" || playerInput == "3")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("bad input, try again");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        static void EndGameDecsion(int keys, string playerInput)
        {
            if (playerInput == "3")
            {
                Console.Clear();
                Console.WriteLine("       ____ ____     ");
                Console.WriteLine("      |    |    |   ");
                Console.WriteLine("      |    |    |   ");
                Console.WriteLine("   ___|____|____|___\n\n");
                Console.WriteLine(" Good job, you choose the right door, you won!!   ");
                Console.WriteLine(" type (e) to walk through the door and leave the house. \n\n");
                playerInput = Console.ReadLine();
                if (playerInput == "e")
                {
                    Console.WriteLine(" \n :) the end...");
                    Thread.Sleep(4000);
                    Console.WriteLine("  Or is it.....?");
                    Thread.Sleep(400);
                    Console.Clear();

                }
            }
            else if (playerInput == "2")
            {
                Console.Clear();
                Console.WriteLine(" Wow, you suck at making decsions, now your dead...");
                Thread.Sleep(2000);
                Console.WriteLine(" Have fun doing this all over again...\n");
                Thread.Sleep(2000);
                Console.WriteLine(" 3");
                Thread.Sleep(1500);
                Console.WriteLine(" 2");
                Thread.Sleep(1500);
                Console.WriteLine(" 1");
                Thread.Sleep(1500);
                keys = 0;
                FirstRoom(ref keys);
            }
            else if (playerInput == "1")
            {
                Console.Clear();
                Console.WriteLine(" Wow, you suck at making decsions, now your dead...");
                Thread.Sleep(2000);
                Console.WriteLine(" Have fun doing this all over again...\n");
                Thread.Sleep(2000);
                Console.WriteLine(" 3");
                Thread.Sleep(1500);
                Console.WriteLine(" 2");
                Thread.Sleep(1500);
                Console.WriteLine(" 1");
                Thread.Sleep(1500);
                keys = 0;
                FirstRoom(ref keys);
            }
        }
    }
}