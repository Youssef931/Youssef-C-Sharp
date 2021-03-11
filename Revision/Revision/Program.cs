using System;
using static System.Console;
namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - for (int i = 0; i <= 5; i++)
            //{
            //    WriteLine("Hello Nazar");
            //    if (i > 2)
            //    {
            //        continue;
            //    }
            //    for (int j = 0; j <= 4; j++)
            //    {
            //      WriteLine("\t Hello world");
            //    }
            //    WriteLine("Hello Nazar");
            //   WriteLine("\n");
            //}
            //********************************************
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                for (int j = 0; j < 10; j++)
                {
                   WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}