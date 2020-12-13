using System;

namespace ConsoleApp3
{
    class Program
    {
        //(1) - static int MNV(int[] MA, out int MI)
        //{
        //    int MNV = MA[0];
        //    MI = 0;
        //    for (int i = 1; i < MA.Length; i++)
        //    {
        //        if (MA[i]<MNV)
        //        {
        //            MNV = MA[i];
        //            MI = i;
        //        }
        //    }
        //    return MNV;
        //}
        //*************************************************
        //(2) - static int MNV(int[] MA, out int MI)
        //{
        //    int MNV = MA[0];
        //    MI = 0;
        //    for (int i = 1; i < MA.Length; i++)
        //    {
        //        if (MA[i] < MNV)
        //        {
        //            MNV = MA[i];
        //            MI = i;
        //        }
        //    }
        //    return MNV;
        //}
        //(1) - static void Main(string[] args)
        //{
        //    int MI;
        //    int[] MA = { 11, 10, 43, 6, 22, 8, 9, 13, 50, 22 };
        //    int MNV1 = MNV(MA, out MI);
        //    Console.WriteLine($"The Minimum Value in MyArray is {MNV1} And The Index is {MI}");
        //}
        //*************************************************
        //(2) - static void Main(string[] args)
        //{
        //    int MI;
        //    int[] MA = { 1, 10, 43, 6, 22, 8, 9, 13, 50, 22 };
        //    int MNV1 = MNV(MA, out MI);
        //    Console.WriteLine($"The Minimum Value in MyArray is {MNV1} And The Index is {MI}");
        //}
    }
}