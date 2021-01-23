using System;
using static System.Console;
namespace _94___Palindrome_ٍString_Function
{
    class Program
    {
        public static bool MPF(string V)
        {
            int MN = 0;
            int MX = V.Length - 1;
            while (true)
            {
                if (MN > MX)
                {
                    return true;
                }
                char A = V[MN];
                char B = V[MX];
                if (char.ToLower(A) != char.ToLower(B))
                {
                    return false;
                }
                MN++;
                MX--;
            }
        }
        static void Main(string[] args)
        {
            string[] MA = { "civic", "deified", "deleved", "Perls", "is", "not", "A", "palindroom", "" };
            foreach (string item in MA)
            {
                Console.WriteLine($"{item} = {MPF(item)}");
            }
        }
    }
}
