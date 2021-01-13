using System;
using static System.Array;
using static System.Console;
namespace _89___MoreArrayOperations_using_Array_Class
{
    class Program
    {
        static void SAF()
        {
            //(1) - WriteLine("working With The Class System.Array");
            //int[] MNS = new[] { 11, 2, 31, 14, 5 };
            //WriteLine($"The Rank of Array = {MNS.Rank}");
            //******************************************
            //(2) - WriteLine("Here is The Array");
            //int[] MNS = new[] { 11, 2, 31, 14, 5 };
            //for (int i = MNS.GetLowerBound(0); i <= MNS.GetUpperBound(0); i++) 
            //{
            //    WriteLine(MNS[i]);
            //******************************************
            //(3) - int[] MNS = new[] { 11, 2, 31, 14, 5 };
            //Sort(MNS);
            //WriteLine("\nThe Sorted Array = ");
            //for (int i = 0; i < MNS.Length; i++)
            //{
            //    WriteLine(MNS[i]);
            //}
            //******************************************
            //(4) - int[] MNS = new[] { 11, 2, 31, 14, 5 };
            //Reverse(MNS);
            //WriteLine("\n the reversed array = ");
            //for (int i = 0; i < MNS.Length; i++)
            //{
            //    Write(MNS[i] + "\n");
            //}
            //WriteLine("\n");
            //******************************************
            //(5) - int[] MNS = new[] { 11, 2, 31, 14, 5 };
            //WriteLine("Cleared out all but........");
            //Clear(MNS, 0, MNS.Length);
            //for (int i = 0; i < MNS.Length; i++)
            //{
            //    Console.WriteLine(MNS[i]);
            //}
            //******************************************
            int[] MNS = new[] { 11, 2, 31, 14, 5 };
            string[] A = ConvertAll(MNS, element => element.ToString());
            WriteLine(string.Join(";",A));
        }
        static void Main(string[] args)
        {
            SAF();
            ReadKey();
        }
    }
}