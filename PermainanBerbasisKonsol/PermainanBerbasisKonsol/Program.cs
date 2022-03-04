using System;

namespace PermainanBerbasisKonsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,81}","Selamat datang di PermainanBerbasisKonsol!");
            Console.WriteLine("{0,80}","Pilihlah permainan yang kamu inginkan :");

            // jangan lupa selalu dikasih \n setiap akhir string
            Console.WriteLine("" +
                "1. Hangman\n" +
                "2. ?\n");

            Console.Write("Pilihanmu : ");
            int intInput = int.Parse(Console.ReadLine());

            switch(intInput)
            {
                case 1:
                    Hangman.Permainan();break;
            }
        }
    }
}
