using static System.Console;
namespace Delegate_Type
{
    delegate int MNN(int MN);
    public class progrrame
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
            MNN N;
            MNN N1 = new MNN(AF);
            MNN N2 = new MNN(MF);
            WriteLine($"N = {N1(3)}");
            N1(4);
            WriteLine(MXN);
            N2(5);
            WriteLine(MXN);
            N = N1 + N2;
            N(5);
            WriteLine(MXN);
        }
    }
}
