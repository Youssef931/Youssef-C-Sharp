using System;
using static System.Console;
namespace Revision_On_29__30_And_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - int MV1 = 2;
            //int T1 = ++MV1;
            //WriteLine("{0}", T1);
            //ReadKey();
            //******************************************
            //(2) - int MV1 = 2;
            //int T1 = MV1++;
            //WriteLine("{0}", T1);
            //ReadKey();
            //******************************************
            //(3) - int MV1 = 2;
            //int T1 = --MV1;
            //WriteLine("{0}", T1);
            //ReadKey();
            //******************************************
            //(4) - int MV1 = 2;
            //int T1 = MV1--;
            //WriteLine("{0}", T1);
            //ReadKey();
            //(Q1) - int MV1 = 5;
            //int T1 = MV1++;
            //WriteLine("{0}", T1);
            ////Q1 = 5;
            //ReadKey();
            //******************************************
            //(Q2) - int MV1 = 5;
            //int T1 = ++MV1;
            //WriteLine("{0}", T1);
            ////Q2 = 6;
            //ReadKey();
            //******************************************
            //(Q3) - int MV1 = 7, MV2 = 2;
            //int T1 = MV1--/++MV2;
            //WriteLine("{0}", T1);
            ////Q3 = 2;
            //ReadKey();
            //******************************************
            //(5) - int MV1 = 7, MV2 = 3;
            //MV1 = MV2;
            //WriteLine($"the result is {MV1}, Var2 = {MV2}");
            //******************************************
            //(6) - int MV1 = 7, MV2 = 3;
            //MV2 = MV1;
            //WriteLine($"the result is {MV1}, Var2 = {MV2}");
            //(7) - int MV1 = 7, MV2 = 3;
            //MV1 += MV2;
            //WriteLine($"the result is {MV1}, Var2 = {MV2}");
            //(8) - int MV1 = 7, MV2 = 3;
            //MV2 += MV1;
            //WriteLine($"the result is {MV1}, Var2 = {MV2}");
            //******************************************
            //(9) - int MV1 = 7, MV2 = 3;
            //MV1 -= MV2;
            //WriteLine($"the result is {MV1}, Var2 = {MV2}");
            //******************************************
            //(10) - int MV1 = 7, MV2 = 3;
            //MV1 %= MV2;
            //WriteLine($"the result is {MV1}, Var2 = {MV2}");
            int T, MV1 = 7, MV2 = 2;
            MV1 /= ++MV2;
            WriteLine(MV1);
        }
    }
}
