using System;

namespace Convert_Command_and_Challenge_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - double myDoubleVar = 2500.45;
            //string myStringVar, mySubstring;
            //myStringVar = Convert.ToString(myDoubleVar);
            //Console.WriteLine("My String var is {0}\n", myStringVar);
            //mySubstring = myStringVar.Substring(0, 2);
            //Console.WriteLine($"My variable is {myDoubleVar}\n");
            //Console.WriteLine("My String var is {0}\n", mySubstring);
            //*********************************************
            //2 - double myDoubleVar = 2500.45;
            //string myStringVar, mySubstring;
            //myStringVar = Convert.ToString(myDoubleVar);
            //Console.WriteLine("My String var is {0}\n", myStringVar);
            //mySubstring = myStringVar.Substring(0, 2);
            //Console.WriteLine($"My variable is {myDoubleVar}\n");
            ////Console.WriteLine("My String var is {0}\n", mySubstring);
            //*********************************************
            float myFlaovar = 45.56f;
            string myStrivar, mysubStrivar;
            myStrivar = Convert.ToString(myFlaovar);
            Console.WriteLine($"my Stri var is {myStrivar}\n");
            mysubStrivar = myStrivar.Substring(2,3);
            Console.WriteLine("My floa var is {0}\n", myFlaovar);
            Console.WriteLine("my Stri var is {0}\n", mysubStrivar);
        }
    }
}
