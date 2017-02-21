using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            bool AM = true;
            bool PM = false;

            while (true)
            {
                while (seconds <= 50)
                {
                    Console.Clear();
                    if (AM)
                    {
                        Console.WriteLine(hours.ToString("12") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00"));
                        //wait 1 second
                        Thread.Sleep(1000);
                        seconds++;
                    }
                    else
                    {
                        Console.WriteLine(hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00"));
                        
                    }
                    minutes++;
                }
               hours++;
            }
        }
    }
}
