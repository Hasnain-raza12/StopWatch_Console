using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace StopWatch_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0;
            int min = 0;
            int hour = 0;

            try
            {
                for (int i = sec; i >= 0; i++)
                {
                    Console.CursorLeft = 22;
                    Console.Write("STOPWATCH  {0}:{1}:{2} ", hour, min, i);
                    Thread.Sleep(1000);

                    if (i > 59)
                    {

                        min++;
                        i = sec;
                        if (min > 59)
                        {
                            hour++;
                            min = 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            Console.ReadLine();
        }
    }
}
