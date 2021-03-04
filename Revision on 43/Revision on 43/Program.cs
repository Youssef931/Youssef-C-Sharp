using System;

namespace Revision_on_43
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - for (int i = 0; i <= 5; i++)
            //{
            //    if (i > 2)
            //        break;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t Hello");
            //    }
            //}
            //******************************************
            //(2) - for (int i = 0; i <= 5; i++)
            //{
            //    //if (i > 2)
            //    //    break;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t Hello");
            //    }
            //}
            //******************************************
            for (int i = 0; i <= 10; i++)
            {
                if (i>7)
                {
                    break;
                }
                for (int j = 0; j <= 12; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}