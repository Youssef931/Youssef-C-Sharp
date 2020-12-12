using System;

namespace Return_Value_Functions_in_CSharp
{
    class Program
    {
        //(1) - static void AN(int MFN, int MSN)
        //{
        //    int temp = MFN + MSN;
        //    Console.WriteLine($"{temp}");
        //}
        //*************************************************
        //(2) - static void AN(int MFN, int MSN)
        //{
        //    int temp = MFN + MSN;
        //    Console.WriteLine($"{temp}");
        //}
        //static int AN2(int MFN, int MSN)
        //{
        //    int temp = MFN + MSN;
        //    return temp;
        //}
        //*************************************************
        //(3) - static void AN(int MFN, int MSN)
        //{
        //    int temp = MFN + MSN;
        //    Console.WriteLine($"{temp}");
        //}
        //static int AN2(int MFN, int MSN)
        //{
        //    int temp = MFN + MSN;
        //    return temp;
        //}
        static void Main(string[] args)
        {
            //(1) - int MV1 = 5, MV2 = 3;
            //AN(MV1, MV2);
            //*********************************************
            //(2) - int MV1 = 5, MV2 = 3, T;
            //AN(MV1, MV2);
            //T = AN2(MV1, MV2);
            //Console.WriteLine($"{T}");
            //*********************************************
            //(3) - int MV1 = 5, MV2 = 3;
            //AN(MV1, MV2);
            //Console.WriteLine($"{AN2(MV1, MV2)}");
        }
    }
}
