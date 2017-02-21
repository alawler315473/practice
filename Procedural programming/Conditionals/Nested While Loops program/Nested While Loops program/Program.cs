using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_While_Loops_program
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 9; i >= 0; i--)
                {
                    Console.WriteLine(j + "" + i + "");
                }
            }
        }
    }
}
