using System;

namespace Revision_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //34,35(1) - int Var1 = 9, Var2 = 6;
            //if (Var1 == 9)
            //{
            //    Console.WriteLine($"Var1 == 9");
            //    if (Var2 == 7)
            //    {
            //        Console.WriteLine($"Var2 == 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Var2 is != 9");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Var1 is != 9");
            //}
            //*********************************************
            //34,35(2) - int Var1 = 9, Var2 = 6;
            //if (Var1 == 9)
            //{
            //    Console.WriteLine($"Var1 == 9");
            //    if (Var2 == 7)
            //    {
            //        Console.WriteLine($"Var2 == 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Var2 is != 7");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Var1 is != 9");
            //}
            //*********************************************
            //int Var1 = 9, Var2 = 6;
            //if (Var1 == 10)
            //{
            //    Console.WriteLine($"Var1 == 9");
            //    if (Var2 == 7)
            //    {
            //        Console.WriteLine($"Var2 == 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Var2 is != 7");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Var1 is != 9");
            //}
            //*********************************************
            //34,35(Q1) - int Var1 = 10, Var2 = 6, Var3 = 8;
            //if (Var1 == 10)
            //{
            //    Console.WriteLine($"Var1 == 10");
            //    if ((Var2 >= 5) && (Var3 <= 9)) 
            //    {
            //        Console.WriteLine("The Conditions are true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The Conditions are false");
            //    }
            //}
            //*********************************************
            int Var = 4, Var2 = 6;
            if (Var <= 3 && Var2 >= 5) 
            {
                Console.WriteLine("Choice1 is true");
            }
            else if (Var <= 4 && Var2 >=6)
            {
                Console.WriteLine("Choice2 is true");
            }
            else if (Var2 > 5)
            {
                Console.WriteLine("Choice3 is true");
            }
            else
            {
                Console.WriteLine("No One is True");
            }
        }
    }
}
