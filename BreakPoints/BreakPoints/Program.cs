using System;
using static System.Console;
using System.Diagnostics;
namespace BreakPoints
{
    class Program
    {
        public static int AF(int x, int y)
        {
            //Debug.WriteLine($"We started AF");
            int z = x + y;
            //Debug.WriteLine("We Ended AF");
            //Trace.WriteLine("We Ended AF");
            return z;
        }
        public static int MF(int x, int y)
        {
            //Debug.WriteLine("We Started MF");
            int z = x * y;
            //Debug.WriteLine("Ew Ended MF");
            return z;
        }
            static void Main (string[] args)
            {
                int MN, MV = 4, MV2 = 7;
                MN = AF(MV, MV2);
                MN = MF(MV, MV2);
                ReadKey();
            }
        }
    }
