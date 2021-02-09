using System;
using static System.Console;
namespace Revision_on_32_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - int MV = 10;
            //if (MV==10)
            //{
            //    Console.WriteLine($"My Var is equal 10");
            //}
            //******************************************
            //(2) - int MV = 10;
            //if (MV == 10)
            //{
            //    WriteLine($"My Var is equal 10");
            //}
            //else
            //{
            //    WriteLine("My Variable is not equal 10");
            //}
            //******************************************
            //(3) - int MV = 10;
            //if (MV == 10)
            //{
            //    WriteLine($"My Var is equal 10");
            //}
            //else
            //{
            //    WriteLine("My Variable is not equal 10");
            //}
            //******************************************
            //(4) - int MV = 10;
            //if (MV == 10)
            //{
            //    WriteLine($"My Var is equal 10");
            //}
            //else
            //{
            //    WriteLine("My Variable is not equal 10");
            //}
            //int MV1 = 9, MV2 = 7;
            //if ((MV1 <= 7) || (MV2 >= 10))
            //{
            //    WriteLine("The Conditions are true");
            //}
            //else
            //{
            //    WriteLine("My Variables Condition are False");
            //}
            //******************************************
            //(5) - int MV1 = 10;
            //string MR;
            //if (MV1<10)
            //{
            //    MR = "Less than 10";
            //    WriteLine(MR);
            //}
            //if (MV1<10)
            //{
            //    MR = "Greater than 10";
            //    WriteLine(MR);
            //}
            //if (MV1==10)
            //{
            //    MR = "Equal 10";
            //    WriteLine(MR);
            //}
            //******************************************
            //(Q1) - int MV1 = 8;
            //string MR;
            //if (MV1<10)
            //{
            //    MR = "Less Than 10";
            //    WriteLine(MR);
            //}
            //if (MV1>10)
            //{
            //    MR = "Greater than 10";
            //}
            //******************************************
            int MV1 = 10, MV2 = 5, MV3 = 9;
            if ((MV1 <= 11) || (MV2 == 5) && (MV3 >= 8))
            {
                WriteLine("The Conditions are True");
            }
            else
            {
                WriteLine("The Conditions are False");
            }
            if ((MV1 <= 10) || (MV2 == 6) && (MV3 >= 8))
            {
                WriteLine("The Conditions are True");
            }
            else
            {
                WriteLine("The Conditions are false");
            }
        }
        
    }
}
