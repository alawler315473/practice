using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1;
            int var2;
            int var5;
            int var3;
            int var4;

            var1 = 5;
            var2 = 6;

            var1 = var1++;
            var1 = var1 + 3;
            var1 = 7;
            var2 = var2 - var1;
            var1 = 12;
            var1 = var1 + 7;
            var5 = var1 * var2;
            var3 = 8;
            var5 = var1 + var2 + var3;
            var5 = var5 / var3;
            var4 = 9;
            var3 = var3 - 4;
            var5 = var3 * var4;
            var5 = var5 * 2;
            var5 = var5 /3;

        }
    }
}
