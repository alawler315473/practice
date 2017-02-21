using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CreateUserLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] accArray = new string[1];

            List<string> passwordList = new List<string>();
            List<string> userNameLists = new List<string>();
            userNameLists.Add("ww2");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter (Login) / or type (CA): ");
                string userInput = Console.ReadLine();
                if (userInput == "Login")
                {
                    Console.Clear();
                    Console.WriteLine("Enter a username: ");
                    string userNameInput = Console.ReadLine();
                    for (int k = 0; k < userNameLists.Count; k++)
                    {
                        if (userNameInput == userNameLists[k])
                        {
                            Console.WriteLine("Enter your password: ");
                            string passwordInput = Console.ReadLine();
                            for (k = 0; k < passwordList.Count; k++)
                            {
                                if (passwordInput == passwordList[k])
                                {
                                    Console.WriteLine("Welcome " + userNameInput + ".");
                                    Thread.Sleep(1000);
                                    return;
                                }
                            }
                        }
                    }
                    Console.WriteLine("Wrong credidentals");
                    Thread.Sleep(1000);
                }
                //CREATE ACCOUNT
                else if (userInput == "CA")
                {
                    //CREATE USERNAME
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter a username: ");
                        string username = (Console.ReadLine());
                        bool uniqueName = true;
                        for (int k = 0; k < userNameLists.Count; k++)
                        {
                            if (username == userNameLists[k])
                            {
                                Console.WriteLine("Names Already taken: ");
                                Thread.Sleep(1000);
                                uniqueName = false;
                                break;
                            }
                        }
                        if (uniqueName)
                        {
                            userNameLists.Add(username);
                            break;
                        }
                    }

                    //CREATE PASSWORD
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter a password: ");
                        string password = (Console.ReadLine());
                        Console.WriteLine("Confirm Password: ");
                        string conPassword = Console.ReadLine();

                        if (password == conPassword)
                        {
                            passwordList.Add(password);
                            break;
                        }
                        else if (password != conPassword)
                        {
                            Console.WriteLine("Passwords don't match.");
                            Thread.Sleep(1000);
                        }
                    }
                }
            }           
        }
    }
}

