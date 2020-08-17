using System;

namespace Boolean_Operatorors
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool myResult;
            //int myvar1 = 5, myvar2 = 8;
            //myResult = (myvar1 <= 5) && (myvar2 > 8);
            //Console.WriteLine("R is {0}", myResult);
            //*********************************************
            int myvar1 = 9;
            int myvar2 = 11;
            bool temp1;
            temp1 = (myvar1 < 10) && (myvar2 <= 11);
            //1 - T;
            bool temp2;
            temp2 = (myvar1 < 10) || (myvar2 <= 11);
            //2 - T;
            Console.WriteLine("R1 is {0}\nR2 is {1}", temp1, temp2);
        }
    }
}
