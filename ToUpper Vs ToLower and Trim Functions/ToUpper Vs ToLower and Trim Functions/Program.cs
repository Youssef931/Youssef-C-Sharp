using System;

namespace ToUpper_Vs_ToLower_and_Trim_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - string MS, MS2;
            //Console.WriteLine("Please Enter Your String");
            //MS = Console.ReadLine();
            //MS2 = MS.ToUpper();
            //Console.WriteLine($"{MS2}");
            //*********************************************
            //(2) - string MS, MS2;
            //Console.WriteLine("Please Enter Your String");
            //MS = Console.ReadLine();
            //MS2 = MS.ToUpper();
            //Console.WriteLine($"{MS2}");
            //MS2 = MS.ToLower();
            //Console.WriteLine($"{MS2}");
            //*********************************************
            //(3) - string MS, MS2;
            //Console.WriteLine("Please Enter Your String");
            //MS = Console.ReadLine();
            ////MS2 = MS.ToUpper();
            ////Console.WriteLine($"{MS2}");
            ////MS2 = MS.ToLower();
            ////Console.WriteLine($"{MS2}");
            //MS2 = MS.Trim();
            //Console.WriteLine($"{MS2}");
            //*********************************************
            string MS, MS2;
            char[] MTC = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("PLease Enter Your String");
            MS = Console.ReadLine();
            MS = MS.ToLower();
            MS2 = MS.Trim(MTC);
            Console.WriteLine($"{MS2}");
        }
    }
}