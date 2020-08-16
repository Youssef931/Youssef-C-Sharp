using System;

namespace Mathematical_Opereators
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - int myvar1 = 15;
            //int myvar2 = 10;
            //int temp1 = myvar1 + myvar2;
            //Console.WriteLine("The Result is {0}", temp1);
            //**********************************************
            //2 - int myvar1 = 15;
            //int myvar2 = 10;
            //int temp1 = myvar1 + myvar2;
            //int temp2 = myvar1 - myvar2;
            //Console.WriteLine("The Result is {0}\nThe result 2 is {1}", temp1, temp2);
            //**********************************************
            //4 - int myvar1 = 15;
            //int myvar2 = 10;
            //int temp1 = myvar1 + myvar2;
            //int temp2 = myvar1 - myvar2;
            //int temp3 = myvar1 % myvar2;
            //Console.WriteLine("The Result is {0}\nThe result 2 is {1}\nThe Reminder is {2}", temp1, temp2,temp3);
            //**********************************************
            //5 - int myvar1 = 15;
            //int temp4 = + myvar1;
            //int temp5 = - myvar1;
            //Console.WriteLine("{0}\n{1}", temp4, temp5);
            //**********************************************
            //6 - int myNegVar = -10;
            //int myvar1 = 15;
            //int temp4 = +myvar1;
            //int temp5 = -myvar1;
            //int temp6 = +myNegVar;
            //Console.WriteLine("{0}\n{1}\n{2}", temp4, temp5, temp6);
            //**********************************************
            //7 - string myStr1 = "This is wonderful";
            //string myStr2 = "How is it ,";
            //myStr1 = myStr2 + myStr1;
            //Console.WriteLine("{0}", myStr1);
            //**********************************************
            sbyte var1 = 7;
            sbyte var2 = 3;
            int Temp1 = var1 + var2;
            int Temp2 = var1 / var2;
            int Temp3 = var1 * var2;
            int Temp4 = var1 % var2;
            Console.WriteLine("The sum 1 is {0}\nThe sum 2 is {1}\nThe sum 3 is {2}\nThe sum 4 is {3}", Temp1, Temp2, Temp3, Temp4);
            //**********************************************
            string Str1 = "I am ";
            string Str2 = "smart";
            Console.WriteLine("{0}{1}",Str1, Str2);
        }
    }
}
