using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "A string";
            double myDouble1 = 123.123546;
            double myDouble2 = 35.452;
            double myMoney = 1232345.123;
            myMoney = myMoney / 5;
            Console.WriteLine("hello world");
            Console.WriteLine("here we get practicing printing");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here you should be using a variable myString: "+myString);
            Console.WriteLine("myDouble1: " + myDouble1);
            Console.WriteLine("myDouble2: " + myDouble2);
            Console.WriteLine("do that again with formating on the variable");
            Console.WriteLine("myDouble1: " + myDouble1.ToString("F2"));
            Console.WriteLine("myDouble2: " + myDouble2.ToString("F2"));
            Console.WriteLine("myMoney: " + myMoney);
            Console.WriteLine("lets do some inputs");
            Console.WriteLine("please enter something");
            string myInput = Console.ReadLine();
            Console.WriteLine("you wrote: "+ myInput);

            Console.WriteLine("Enter the value of pi to as many didgets as you know");
            string myInputForPi = Console.ReadLine();
            float myIntValue = Convert.ToSingle(myInputForPi);
            Console.WriteLine("sorry I zoned out did you say : "+myIntValue);
            string myInputForPi2 = Console.ReadLine();
            Console.WriteLine("sorry zoned out again, can you enter it one more time?");
            Console.ReadLine();
            float myIntValue2 = Convert.ToSingle(myInputForPi2);

            Console.WriteLine("I think you said: 3.141592653589793238462643383279502884197169");
            Console.WriteLine();
            Console.WriteLine("Wow, your smart...");

        }
    }
}
