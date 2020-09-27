using System;

namespace Break_Loop_Break_Command_and_challenge_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello Nazar");
            //    if (i > 2)
            //        break;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t Hello World");
            //    }
            //    Console.WriteLine("\n");
            //*****************************************
            //2 - for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello Nazar");
            //    //if (i > 2)
            //        //break;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t Hello World");
            //   }
            //}
            //    Console.WriteLine("\n");
            //*****************************************
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                    break;
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("--------------------------");
            }
        }
    }
}
