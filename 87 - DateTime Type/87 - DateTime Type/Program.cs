using System;
using static System.Console;
namespace _87___DateTime_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - WriteLine(DateTime.Now.ToString("hh:mm:ss\nMM dd yyyy"));
            //******************************************
            //(2) - DateTime T = DateTime.Now;
            //string F = "MM dd yyyy\nhh:mm";
            //WriteLine(T.ToString(F));
            //******************************************
            //(3) - DateTime T = DateTime.Now;
            //string F = "MM dd d HH:mm yyyy";
            //WriteLine(T.ToString(F));
            //******************************************
            //(4) - DateTime now = DateTime.Now;
            //WriteLine(now.ToString("d"));
            //WriteLine(now.ToString("D"));
            //WriteLine(now.ToString("f"));
            //WriteLine(now.ToString("g"));
            //WriteLine(now.ToString("G"));
            //WriteLine(now.ToString("m"));
            //WriteLine(now.ToString("M"));
            //WriteLine(now.ToString("o"));
            //WriteLine(now.ToString("O"));
            //WriteLine(now.ToString("s"));
            //WriteLine(now.ToString("t"));
            //WriteLine(now.ToString("T"));
            //WriteLine(now.ToString("u"));
            //WriteLine(now.ToString("U"));
            //WriteLine(now.ToString("y"));
            //WriteLine(now.ToString("Y"));
            //******************************************
            //(5) - DateTime N = DateTime.Now;
            //string R = N.ToString("s ");
            //WriteLine($"{N} [s] = {R}");
            //******************************************
            DateTime N = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                WriteLine(N.ToString("dddd"));
                N = N.AddDays(1);
            }
        }
    }
}
