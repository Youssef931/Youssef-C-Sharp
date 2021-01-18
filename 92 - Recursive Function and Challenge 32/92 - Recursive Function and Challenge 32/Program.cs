using System;
using static System.Console;
namespace _92___Recursive_Function_and_Challenge_32
{
    class Program
    {
        //(1) - static int MRF(int MV, ref int C)
        //{
        //    C++;
        //    if (MV == 0)
        //    {
        //        return 0;
        //    }
        //    else if (MV<10)
        //    {
        //        return MRF(MV + 1, ref C);
        //    }
        //    return MV;
        //}
        //**********************************************
       static int FN(int V,ref int C)
        {
            C++;
            if (V == 0)
            {
                return 1;
            }
            else if (V <= 5)
            {
                return V * FN(V - 1, ref C);
            }
            return V;
        }

        static void Main(string[] args)
        {
            //(1) - int C = 0, MR;
            //MR = MRF(4, ref C);
            //WriteLine($"My Results is {MR} and counter value is {C}");
            //******************************************
            int C1 = 0, N1;
            N1 = FN(5, ref C1);
            WriteLine($"My Result is {N1}And Counter is {C1}");
        }
    }
}
