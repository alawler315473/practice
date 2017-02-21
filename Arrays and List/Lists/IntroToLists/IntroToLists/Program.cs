using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>(4);
            List<double> dblList = new List<double>(3);
            List<string> strngList = new List<string>(4);
            List<bool> boolList = new List<bool>();

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            dblList.Add(123.4);
            dblList.Add(43.4);
            dblList.Add(12.4);
            dblList.Add(65.7);

            strngList.Add("what");
            strngList.Add("did one");
            strngList.Add("ocean");
            strngList.Add("say to");
            strngList.Add("the other?");

            boolList.Add(true);
            boolList.Add(true);
            boolList.Add(false);

            intList[0] = 13;
            intList[1] = 8;
            intList[2] = 9;
            intList[3] = 7;
            intList[4] = 6;

            dblList[0] = 13;
            dblList[1] = 17.7;
            dblList[3] = 21.512;

            for (int k = 0; k < intList.Count(); k++)
            {
                Console.WriteLine(intList[k]);
            }
            Console.WriteLine();
            for(int k = 0; k < dblList.Count; k++)
            {
                Console.WriteLine(dblList[k]);
            }

            strngList[3] = "just";
            strngList[1] = ",";
            strngList[4] = "waved";
            strngList[2] = "it";
            strngList[0] = "nothing";

            for (int k = 1; k < 11; k++)
            {
                intList.Add(k);
            }
            dblList.Add(12);
            dblList.Add(2.3);
            dblList.Add(5.43);

            Console.WriteLine();
            for(int k = 0; k<intList.Count; k++)
            {
                Console.WriteLine(intList[k]);
            }
            Console.WriteLine();
            for (int k = 0; k < dblList.Count; k++)
            {
                Console.WriteLine(dblList[k]);
            }
            Console.WriteLine();
            for (int k = 0; k < strngList.Count; k++)
            {
                Console.WriteLine(strngList[k]);
            }

            strngList[3] = "When he";
            strngList[1] = "you call ";
            strngList[4] = "skips church?";
            strngList[2] = "Batman";
            strngList[0] = "What do ";

            Console.WriteLine();
            for (int k = 0; k < strngList.Count; k++)
            {
                Console.WriteLine(strngList[k]);
            }

            strngList.Add("Christian");
            strngList.Add("Bale");

            Console.WriteLine();
            for (int k = 0; k < strngList.Count; k++)
            {
                Console.WriteLine(strngList[k]);
            }
            strngList[3] = "round";
            strngList[1] = "Invented ";
            strngList[6] = "Cumference ";
            strngList[4] = "table?";
            strngList[2] = "the";
            strngList[5] = "Sir ";
            strngList[0] = "Who ";

            Console.WriteLine();
            for (int k = 0; k < strngList.Count; k++)
            {
                Console.WriteLine(strngList[k]);
            }
        }
    }
}
