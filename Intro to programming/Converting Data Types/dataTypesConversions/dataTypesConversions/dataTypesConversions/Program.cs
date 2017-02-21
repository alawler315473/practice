using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypesConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //fix the errors in the conversions below then run in debug
            //mode and put the current values of the variable 
            //after the line is executed next to each line
            string myString = "1";//"1"
            char myChar = '2'; //'2'
            float myFloat = 10.7f;
            double myDouble = 10.9123457890;
            bool myBool = true;
            long myLong = 123123;
            int myInt = 12;
            myDouble = myFloat;
            myDouble = myInt;
            myDouble = myLong;
            myDouble = Convert.ToDouble(myString);
            myDouble = myChar;
            myDouble = Convert.ToDouble(myBool);

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myFloat = Convert.ToSingle(myDouble);
            myFloat = myInt;
            myFloat = myLong;
            myFloat = Convert.ToSingle(myString);
            myFloat = myChar;
            myFloat = Convert.ToSingle(myBool);

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            //for double/float to int does this round down or up?
            //how could you make it round the other way?
            //use explicit cast//math.floor or subtract .5 before convert
            myInt = Convert.ToInt32(myDouble); 
            myInt = Convert.ToInt32(myFloat);
            myInt = Convert.ToInt32(myLong);
            myInt = Convert.ToInt32(myString);
            myInt = myChar;
            myInt = Convert.ToInt32(myBool);

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myLong = Convert.ToInt64(myDouble);
            myLong = Convert.ToInt64(myFloat);
            myLong = Convert.ToInt64(myInt);
            myLong = Convert.ToInt64(myString);
            myLong = Convert.ToInt64(myChar);
            myLong = Convert.ToInt64(myBool);

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myString = Convert.ToString(myDouble);
            myString = Convert.ToString(myFloat);
            myString = Convert.ToString(myInt);
            myString = Convert.ToString(myLong);
            myString = Convert.ToString(myChar);
            myString = Convert.ToString(myBool);

            myString = "1";//"1"
            myChar = '2';
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 3;
            myInt = 1;


            myChar = Convert.ToChar(myInt);
            myChar = Convert.ToChar(myLong);
            myChar = Convert.ToChar(myString);

            myString = "1";//"1"
            myChar = '2';
            myFloat = 1.7f;
            myDouble = 0.9123457890;
            myBool = true;
            myLong = 0;
            myInt = 1; 
            
            myBool = Convert.ToBoolean(myDouble);
            myBool = Convert.ToBoolean(myFloat);
            myBool = Convert.ToBoolean(myInt);
            myBool = Convert.ToBoolean(myLong);
        }
    }
}
