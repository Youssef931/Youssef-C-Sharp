using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Revision_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //39,40,41(1) - double mySalary = 1000.20, total = 0.0;
            //int i = 0;
            //do
            //{
            //    total += mySalary;
            //    i++;
            //    Console.WriteLine($"{i}");
            //} while (i < 10);
            //Console.WriteLine($"{total}");
            //*********************************************
            //39,40,41(Q1) - double mysalary = 20, total = 1000; ;
            //int i = 1;
            //do
            //{
            //    total += mysalary;
            //    i++;
            //    Console.WriteLine($"{i},total is {total}");
            //} while (total < 2000);
            //Console.WriteLine("The number of years that we want to reach 2000 is 4 & 2 Months");
            //*********************************************
            //39,40,41(2) - int i = 0;
            //double S = 1020.30, total = 0.0;
            //while (i<15)
            //{
            //    total += S;
            //    i++;
            //}
            //Console.WriteLine($"My S {total}");
            //*********************************************
            //39,40,41(Q2) - int i = 0;
            //double exercise = 1, total = 120;
            //while (total > 83)
            //{
            //    total -= exercise;
            //    i++;
            //    Console.WriteLine($"{i}, total is {total}");
            //}
            //Console.WriteLine("The number of exercises = 37");
            //*********************************************
            //39,40,41(3) - int S = 1000, total = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    total += S;
            //}
            //Console.WriteLine($"Salary for 12 month = {total}");
            //***************************************************
            //39,40,41(Q3,1) - double S = 20, total = 1000;
            //for (int i = 1; total < 2000; i++)
            //{
            //    total += S;
            //    Console.WriteLine($"{i}, Total is {total}");
            //}
            //Console.WriteLine("The number of years to reach 2000 = 4 & 2 Months");
            //***************************************************
            //39,40,41(Q3,2) - double exer = 1, total = 120;
            //for (int i = 1; total > 83; i++)
            //{
            //    total -= exer;
            //    Console.WriteLine($"{i}, Total is {total}");
            //}
            //Console.WriteLine($"The number of exercises = 37");
            //***************************************************
            //42(1) - Console.WriteLine("Hello Nazar");
            //for (int j = 0; j < 2; j++)
            //{
            //    Console.WriteLine("\tHello World\n");
            //}
            //*********************************************
            //42(Q1)for (int i = 1; i <= 6; i += 2)
            //{
            //    for (int n = 0; n <= 10; n++)
            //    {
            //        int y = i * n;
            //        Console.WriteLine("{0} * {1} = {2}", i, n, y);
            //    }
            //}
            //*********************************************
            for (int i = 0; i <= 6; i+=2)
            {
                for (int j = 0; j <= 12; j++)
                {
                    int y = i * j;
                    Console.WriteLine($"{i} * {j} = {y}");
                }
            }
        }
    }
}
