using System;
using static System.Console;
namespace _93___Optional_Parameters_in_C_Sharp
{
    class Program
    {
        public static void PV(string N = "Youssef Aly", int A = 11)
        {
            WriteLine($"Name is {N}, Age is {A}");
        }
        static void Main(string[] args)
        {
            string N = "Hossam";
            int A = 34;
            PV();
            PV(N);
            PV(N, A);
            PV(N: "Aly", A: 52);
        }
    }
}
