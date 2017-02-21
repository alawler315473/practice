using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            double myDecimal = 15.1;
            int myInteger = 10;
            string myString = ("frank");
            string myOtherString = ("Food is Good");
            bool myBool = true;
            double myWord = Convert.ToDouble(myDecimal);
            myDecimal = Convert.ToSingle(myBool);
            int myOtherInt;
            myOtherInt = myInteger / 2; //initialize myOtherInt to half of myInteger
            myOtherInt = myOtherInt + 1; //add 1 to myOtherInt
            myInteger = 5 + myInteger; //add five to myInteger

            //Actual Program:
            double myInt = 2;
            string myString2 = (" ROFL COPTER ");
            Console.WriteLine(myString2);
            Console.WriteLine(myInt);
            myInt = myInt + 5;
            double anotherVar = myInt * 2; 
            double aVar = anotherVar / 10;
            Console.WriteLine(aVar);
            string stringVar;
            stringVar = Convert.ToString(myInt);
            stringVar = stringVar + myString2;
            Console.WriteLine("stringVar holds: " + stringVar);
            Console.WriteLine("Enter a number below");
            string var6 = Console.ReadLine();
            var6 = Convert.ToString(var6);
            var6 = var6 +12;
            Console.WriteLine(var6);

        }
    }
}
