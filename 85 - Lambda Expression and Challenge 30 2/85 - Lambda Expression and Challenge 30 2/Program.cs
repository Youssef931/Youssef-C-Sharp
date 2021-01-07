using static System.Console;
using System;
namespace _85___Lambda_Expression_and_Challenge_30_2
{
    delegate int MNN(int MN);
    class Program
    {
        //(1) - static int MN = 3;
        static void Main(string[] args)
        {
            //(1) - MNN N = x => x + MN;
            //MNN N1 = x => x * MN;
            //WriteLine($"MY X No. = {N(3)}");
            //WriteLine($"MY X No. = {N1(4)}");
            //******************************************
            //(2) - Func<int, bool> func2 = x => x % 2 != 0;
            //int[] MA = { 1, 2, 3, 4, 5, 6 };
            //for (int i = 0; i < MA.Length; i++)
            //{
            //    WriteLine(func2.Invoke(MA[i]));
            //}
            //******************************************
            Func<int, bool> func1 = x => x > 10;
            int[] MA = { 6, 19, 20, 40, 40, 100, 5, 3, 4, 2 };
            for (int i = 0; i < MA.Length; i++)
            {
                WriteLine(func1.Invoke(MA[i]));
            }
            ReadKey();
        }
    }
}