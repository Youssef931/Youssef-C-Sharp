using System;

namespace Variables_Scope
{
    class Program
    {
        //(1) - static void PMS()
        //{
        //    string MS = "My Str Inside The PMS";
        //    Console.WriteLine($"{MS}");
        //}
        //*************************************************
        //(2) - static string MS;
        //static void PMS()
        //{
        //    string MS = "My Str Inside The PMS";
        //    Console.WriteLine($"{MS}");
        //    Console.WriteLine($"{Program.MS}");
        //}
        //*************************************************
        static string MS2;
        static void PMS()
        {
            string MS = "My Str Inside The PMS";
            Console.WriteLine($"{MS}");
            Console.WriteLine($"{MS2}");
        }
        static void Main(string[] args)
        {
            //(1) - string MS = "My Str Inside The Main";
            //PMS();
            //Console.WriteLine($"{MS}");
            //*********************************************
            //(2) - string MS = "My Str Inside The Main";
            //Program.MS = "Global Var";
            //PMS();
            //Console.WriteLine($"{MS}");
            //Console.WriteLine($"{Program.MS}");
            //*********************************************
            //(3) - string MS = "My Str Inside The Main";
            //MS2 = "Global Var";
            //PMS();
            //Console.WriteLine($"{MS}");
            //Console.WriteLine($"{MS2}");
        }
    }
}
