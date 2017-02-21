using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray1 = new int[49];
            int[] myIntArray2 = new int[99];
            int[] myIntArray3 = new int[99];
            double[] myDoubleArray2 = new double[199];



            int k = 0;
            while (k < myIntArray1.Length)
            {
                myIntArray1[k] = k;
                k++;
            }
            k = 0;
            while (k < myIntArray1.Length)
            {
                Console.WriteLine(myIntArray1[k]);
                k++;
            }


            k = 0;
            while (k < myIntArray2.Length)
            {
                myIntArray2[k] = k * 2;
                k++;
            }
            for (k = 0; k < myIntArray2.Length; k++)
            {
                Console.WriteLine(myIntArray2[k]);
            }


            k = 0;
            while (k < myIntArray3.Length)
            {
                myIntArray3[k] = k * 2 + 1;
                k++;
            }
            for (k = 0; k < myIntArray3.Length; k++)
            {
                Console.WriteLine(myIntArray3[k]);
            }


            k = 0;
            while (k < myDoubleArray2.Length)
            {
                myDoubleArray2[k] = k/2.0;
                k++;
            }           
            for(k = 0;k < myDoubleArray2.Length; k++)
            {
                Console.WriteLine(k);
            }
            k = 0;
            for(k = 1; k < myIntArray1.Length; k++)
            {
                myIntArray1[k] = k;
                myIntArray1[k] = myIntArray1[k] + myIntArray1[k-1];
                Console.WriteLine(myIntArray1[k]);
            }
        }
    }
}
