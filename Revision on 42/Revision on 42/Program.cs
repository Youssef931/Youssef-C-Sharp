using System;
using static System.Console;
namespace Revision_on_42
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - for (int i = 0; i < 3; i++)
            //{
            //    WriteLine("Hello Youssef");
            //    for (int j = 0; j < 2; j++)
            //    {
            //        WriteLine("\tHello World");
            //    }
            //    WriteLine("\n");
            //}
            //******************************************
            for (int i = 1; i <= 6; i += 2)
            {
                for (int n = 0; n <= 10; n++)
                {
                    int y = i * n;
                    Console.WriteLine("{0} * {1} = {2}", i, n, y);
                }
            }

        }
    }
}
