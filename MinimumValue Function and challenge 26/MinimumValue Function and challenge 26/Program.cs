using System;

namespace MinimumValue_Function_and_challenge_26
{
    class Program
    {
        //(1) - static int MNV(int[] MA)
        //{
        //    int MNV = MA[0];
        //    for (int i = 1; i < MA.Length; i++)
        //    {
        //        if (MA[i] < MNV)
        //        {
        //            MNV = MA[i];
        //        }
        //    }
        //    return MNV;
        //}
        //*************************************************
        static double avg(int[] r)
        {
            double value = 0;
            for (int i = 0; i < r.Length; i++)
            {
                value += r[i];
            }
            value = value / 7;
            return value;
        }
        static void Main(string[] args)
        {
            //(1) - int[] MA = {11, 10, 3, 6, 2, 8, 9, 3, 50, 2};
            //int MNV2 = MNV(MA);
            //Console.WriteLine($"The Min Value is {MNV2}");
            //*********************************************
            int[] degree = { 100, 100, 100, 100, 0, 100, 100 };
            double deg = avg(degree);
            double value = 0;
            for (int i = 0; i < degree.Length; i++)
            {
                value += degree[i];
            }
            Console.WriteLine($"The MAX AVG in the subjects is {value}");
            Console.WriteLine($"The AVG for the student is {deg}");
        }
    }
}