using System;

namespace Variable_Scope_in_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, index = 0;
            for (i = 0; i < 10; i++)
            {
                index = i;
                Console.WriteLine($"{index}");
            }
            Console.WriteLine($"Last Index OutPut int loop : {index}");
        }
    }
}
