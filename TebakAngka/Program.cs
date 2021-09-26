using System;

// namespace-nya
namespace TebakAngka
{
    // kelas utama yang dipakai
    class Program
    {
        // tempat memulai program
        static void Main(string[] args)
        {
            InfoApp(); // memberi info

            SapaPemain(); // menyapa para pemain

            // game akan terus diulang
            while (true)
            {
                // membuat obyek Random
                Random acak = new Random();

                // angka benar
                int benar = acak.Next(1, 10);

                // inisiasi variabel tebak
                int tebak = 0;

                // minta nomor
                Console.WriteLine("pilihlah angka 1 sampai 10");

                // jika angka tak benar
                while (tebak != benar)
                {
                    // mendapatkan input pengguna
                    string input = Console.ReadLine();

                    // memastikan yang diinput adalah angka
                    if (!int.TryParse(input, out tebak))
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // mengubah warna teks
                        Console.WriteLine("Input yang salah, coba masukkan input yang benar"); // teks yang di-output
                        Console.ResetColor(); // me-reset warna teks konsol
                        continue; // melanjutkan statement-nya
                    }

                    // mengubahnya jadi int dan ditaruh di variabel tebak
                    tebak = Int32.Parse(input);

                    // memastikan input-nya angka


                    // meluruskan kesalahan
                    if (tebak != benar)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // mengubah warna teks
                        Console.WriteLine("Tebakan yang salah, coba lagi!"); // teks yang di-output
                        Console.ResetColor(); // me-reset warna teks konsol
                    }
                }

                // mencetak pesan bahwa tebakan benar
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebakan yang benar, Selamat!");
                Console.ResetColor();

                // meminta untuk bermain lagi
                Console.WriteLine("Apakah anda ingin bermain lagi? [Y] atau [N]");
                string jawaban = Console.ReadLine().ToUpper();

                if (jawaban == "Y")
                {
                    continue;
                }
                else if(jawaban=="N")
                {
                    return;
                }
                else
                {
                    return;
                }
                
                // meminta input pengguna (khusus debug)
                Console.ReadKey();
            }
        }
        static void InfoApp()
        {
            // informasi tentang app
            string namaApp = "Tebak Angka";
            string versi = "1.0.0";
            string pembuat = "Akna Mafaid Ilmi";

            // mengubah penampilan konsol
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            // penjelasan app
            Console.WriteLine("{0}: Versi : {1} Dibuat oleh : {2}", namaApp, versi, pembuat);

            // reset warna konsol
            Console.ResetColor();
        }
        static void SapaPemain()
        {
            // menanyakan nama
            Console.Write("Siapa namamu? : ");

            // input
            string inputNama = Console.ReadLine();

            // bagian game
            Console.WriteLine("halo {0}, mari kita bermain sebuah game", inputNama);

        }
    }
}
