using System;
using static System.Console;
namespace _91___Goto_Statement
{
    class Program
    {
        static int MF()
        {
            int C = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 5)
                    {
                        goto ML;
                    }
                    C++;
                }
                ML:
                continue;
            }
            return C;
        }
        static void Main(string[] args)
        {
            int C = 0;
            //ML2:
            if (C<10)
            {
                C++;
                //goto ML2;
            }
            else
            {
                WriteLine("Done");
                WriteLine(C);
            }
        }
    }
}