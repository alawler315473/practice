using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ArrayProb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tried making a while statement to fix it, didnt work.

            //I set the elements in the array to hold the names
            string[] listOfNames = new string[10] { "Amy Beerhome", "Paul McCartwheel", "Brittany Speared", "Sue Ridge", "Bob Down", "Wacko Jackson", "Sidney Sparkle", "Bill Tarmac", "Bruce Fossil", "Madonna Kebab" };
            Console.WriteLine(" Enter ur name: ");
            string name = Console.ReadLine();

            //made an if statement to catch the name and print out the output
            if (name == listOfNames[0] || name == listOfNames[1] || name == listOfNames[2] || name == listOfNames[3] || name == listOfNames[4] || name == listOfNames[5] || name == listOfNames[6] || name == listOfNames[7] || name == listOfNames[8] || name == listOfNames[9])
            {
                Console.WriteLine(" Your in. you now have a backstage pass");
            }

            //tried making a else if statement to cacth the wrong name of the code, but for some reason it doesnt want to continue through this code.
            else if (name != listOfNames[0] || name != listOfNames[1] || name != listOfNames[2] || name != listOfNames[3] || name != listOfNames[4] || name != listOfNames[5] || name != listOfNames[6] || name != listOfNames[7] || name != listOfNames[8] || name != listOfNames[9])
            {
                Console.WriteLine("Sorry" + name + " is not on the backstage list.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}

