using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPost_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) c - int
            // 2) d - string
            // 3) a - double
            // 4) b - boolean
            // 5) b - assigning a value to a variable.
            // 6) Accolating is when the computer sets aside memory for a variable value
            // 7) Declaring sets a variable type for the variable, Intializing sets a value to a variable

            //  8) 
            //  double myDecimal = 15.1;
            //  int myInteger = 10;
            //  string myString = "its Testing Time!";
            //  string myOtherString = ("Yay Tests!");
            //  bool myBool = true;
            //  double myWord = Convert.ToDouble(myDecimal);
            //  myDecimal = Convert.ToDouble(myBool);
            //  int myOtherInt;
            //  myOtherInt = myInteger / 2 //initialize myOtherInt to half of myInteger
            //  myOtherInt = myOtherInt + 1; //add 1 to myOtherInt
            //  myInteger = 5 + myInteger; //add five to myInteger

            int myInt = 4;
            string myString = "Here take this";
            Console.WriteLine("myInt: "+myInt);
            Console.WriteLine("myString: " + myString);
            myInt = myInt + 4;
            double anotherVar = myInt * 2;
            double aVar = anotherVar / 10;
            Console.WriteLine(aVar);
            string stringVar = Convert.ToString(myInt);
            stringVar = stringVar + myString;
            Console.WriteLine("stringVar: " + stringVar);
            Console.WriteLine("Enter a number ");
            string var6 = Console.ReadLine();
            int var7 = Convert.ToInt32(var6);
            var7 = var7 + 15;
            Console.WriteLine("var7: "+var7);

        }
    }
}
