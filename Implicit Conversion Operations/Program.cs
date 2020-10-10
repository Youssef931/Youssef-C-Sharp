using System;

namespace Implicit_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - long myvar = 1000;
            //float myvar1 = myvar;
            //Console.WriteLine($"{myvar1}");
            //*********************************************
            char myvar = 'G';
            int myvar1 = myvar;
            Console.WriteLine($"{myvar1}");
        }
    }
}
