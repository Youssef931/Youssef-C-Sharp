using System;
using static System.Console;
namespace _88___Params_Keyword_and_Challenge_31
{
    class Program
    {
        //(1) - static double CA(params double[] values)
        //{
        //    WriteLine($"You sent me {values.Length} doubles");
        //    double S = 0;
        //    if (values.Length == 0)
        //        return S;
        //    for (int i = 0; i < values.Length; i++)
        //        S += values[i];
        //        return (S / values.Length);
        //**********************************************
        //(Q1) - static int MX(params int[] V)
        //{
        //    int MX1 = 0; ;
        //    for (int i = 0; i < V.Length; i++)
        //    {
        //        if (MX1<V[i])
        //        {
        //            MX1 = V[i];
        //        }
        //    }
        //    return MX1;
        //}
        static void Main(string[] args)
        {
            //(1) - double A;
            //A = CA(4.0, 3.2, 5.7, 64, 87.2);
            //WriteLine($"Average of data is: {A}");
            //double[] D = { 4.0, 3.2, 5.7 };
            //A = CA(D);
            //WriteLine($"Average of Data is: {A}");
            //WriteLine();
            //WriteLine($"Average of Data is: {CA()}");
            //******************************************
            //(Q1) - int[] A = { 3, 76, 89, 54, 36, 12 };
            //WriteLine(MX(A));
        }
    }
}
