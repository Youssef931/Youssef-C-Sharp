using System;
using static System.Console;
using System.Diagnostics;
namespace Debugging_Mod_Vs_Release_Mod
 
{
    class Program
    {
        public static int AF(int x,int y)
        {
            Debug.WriteLine($"We started AF");
            int z = x + y;
            Debug.WriteLine("We Ended AF");
            Trace.WriteLine("We Ended AF");
            return z;
        }
        public static int MF(int x,int y)
        {
            Debug.WriteLine("We Started MF");
            int z = x * y;
            Debug.WriteLine("Ew Ended MF");
            return z;
        }
        public static void WF(int z)
        {
            Debug.WriteLine("We Started WF");
            WriteLine($"{z}");
            Debug.WriteLine("We Ended WF");
        }
        static void Main(string[] args)
        {
            int MN, MV = 4, MV2 = 7;
            MN = AF(MV, MV2);
            WF(MN);
            MN = MF(MV, MV2);
            WF(MN);
            ReadKey();
        }
    }
}
