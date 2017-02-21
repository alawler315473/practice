using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            //fix the syntax errors in the code below so that it compiles and runs.
            // once fixed what does the code do?
            int variable1 = 5489;
            int variable2 = 64;
            int variable3 = 123;
            int variable4 = 31;
            int variable5 = 21;
            int tempVariable = 0;
            tempVariable = variable1;
            variable1 = variable5;
            variable5 = tempVariable;
            tempVariable = variable2;
            variable2 = variable4;
            variable4 = variable3;
            variable3 = tempVariable;
        }
    }
}
