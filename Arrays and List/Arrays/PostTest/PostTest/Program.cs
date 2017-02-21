using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10);
            double[] myArray = new double[10];

            for (int k = 0; k < myList.Count; k++)
            {
                myList.Add(k+2);
                Console.WriteLine(k);              
            }
        }
    }
}
