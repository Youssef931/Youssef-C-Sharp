using System;

namespace Multicasting_Delegate
{ 
    delegate int MNN(int MN);
    class Program
    {
        static int MXN = 3;
        static int AF(int N)
        {
            MXN += N;
            return MXN;
        }
        static int MF(int N)
        {
            MXN *= N;
            return MXN;
        }
        static void Main(string[] args)
        {
            MNN n;
            MNN n1 = new MNN(AF);
            MNN n2 = new MNN(MF);
            n1(4);
            Console.WriteLine(MXN);
            n2(5);
            Console.WriteLine(MXN);
            n = n1 + n2;                                                                                                                     
            n(5);
            Console.WriteLine(MXN);
        }
    }
}