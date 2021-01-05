using static System.Console;
using OB = B.OB.MB;
using YB = B.YB.MB;
namespace _83___Using_Namespaces_in_Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Those Are My Family");
            YB.print();
            OB.print();
            ReadKey();
        }
    }
}
namespace B
{
    namespace YB
    {
        class MB
        {
            public static void print()
            {
                WriteLine("Yassen");
            }
        }
    }
    namespace OB
    {
        class MB
        {
            public static void print()
            {
                WriteLine("Nada");
            }
        }
    }
}