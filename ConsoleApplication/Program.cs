using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //input
            BigInteger a = 1000003814;
            int argument = 3;
            string b = "";
            int t = 1;
            object c = 1;

            //output
            Console.WriteLine("ini adalah kodingan saya tertanggal : " + DateTime.Now);
            Tes(argument);
            Console.WriteLine(b);
            Console.ReadKey();
            
        }

        private static void Tes(int a)
        {
            a = 1;
            Console.WriteLine(a);
        }
    }
}