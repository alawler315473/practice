using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "There once was a person named ";
            string s2 = " who lived in ";
            string s3 = "\nand who loved ";
            string s4 = ". At the age of ";
            string s5 = ", ";
            string s6 = " graduated \nfrom high school and went to work in a ";
            string s7 = " factory.\n";
            string s8 = " got married and had ";
            string s9 = " children and a pet ";
            string s10 = " named ";
            string s11 = ".\nEvery weekend the family and ";
            string s12 = " had fun ";
            string s13 = " together.";

            Console.WriteLine("Enter the following information and I will tell you a story \n");
            Console.WriteLine();

            Console.WriteLine("Enter your name below \n");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a city below \n");
            string city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter an activity \n");
            string activity = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter an animal \n");
            string animal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a product or food \n");
            string product = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a noun and a adjective \n");
            string adjNoun = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a number between 10 - 50 \n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter a number between 0 - 15 \n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine();
            Console.Write(s1 + name + s2 + city + s3 + activity + s4 + num1 + s5 + name + s6 + product + s7 + name + s8 + num2 + s9 + animal + s10 + adjNoun + s11 + adjNoun + s12 + activity + s13);
            Console.WriteLine();

        }
    }
}
