using System;

namespace Delegate_Type
{
    delegate int MNN(int MN);
    class Program
    {
        static int MXN = 3;
        static int AF (int N)
        {
            MXN += N;
            return MXN;
        }
        static int MF (int N)
        {
            MXN *= N;
            return MXN;
        }
        static void Main(string[] args)
        {
            MNN N1 = new MNN(AF);
            MNN N2 = new MNN(MF);
            N1(4);
            Console.WriteLine($"{MXN}");
            N2(5);
            Console.WriteLine($"{MXN}");
        }
    }
}
