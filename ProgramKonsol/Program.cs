using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramKonsol
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Mobil mobilToyota1 = new Mobil("Toyota", "Hatchback", 2019, 100);
            Mobil mobilToyota2 = new Mobil(mobilToyota1);
            Mobil mobil = new Mobil();
            //output
            mobilToyota1.getInfoMobil();
            Console.WriteLine("--------------");
            mobilToyota2.getInfoMobil();
            Console.WriteLine("--------------");
            mobil.getInfoMobil();
            Console.ReadKey();
        }
        /// <summary>
        /// anjir, ini membaca sebuah file
        /// </summary>
        /// <param name="fileName"></param>
        static void ReadFile(string fileName)
        {
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                // Exception handler for FileNotFoundException
                // We just inform the user that there is no such file
                Console.WriteLine(
                "The file '{0}' is not found.", fileName);
            }
            catch (IOException ioe)
            {
                // Exception handler for other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
    class Mobil
    {
        public string pabrikan;
        public string model;
        public int thnPembuatan;
        public int kondisi;
        public Mobil()
        {
            pabrikan = "Mazda";
            model = "RX8";
            thnPembuatan = 2004;
            kondisi = 100;
        }
        // Parameterized Constructor Pertama
        public Mobil(string pabrikan, string model, int thnPembuatan, int kondisi)
        {
            // Gunakan kata kunci this untuk membedakan antara
            // field dan parameter
            // sebelah kiri operator adalah nama field dari
            // objek saat ini (this object)
            // sebelah kanan operator adalah nama parameter dari
            // constructor
            this.pabrikan = pabrikan;
            this.model = model;
            this.thnPembuatan = thnPembuatan;
            this.kondisi = kondisi;
        }
        // Constructor Kedua
        public Mobil(string pabrikan, int thnPembuatan)
        {
            this.pabrikan = pabrikan;
            this.thnPembuatan = thnPembuatan;
        }
        // Copy Constructor
        public Mobil(Mobil mobil)
        {
            pabrikan = mobil.pabrikan;
            model = mobil.model;
            thnPembuatan = mobil.thnPembuatan;
            kondisi = mobil.kondisi;
        }
        public void getInfoMobil()
        {
            Console.WriteLine("Pabrikan: {0}", pabrikan);
            Console.WriteLine("Tipe Kendaraan: {0}", model);
            Console.WriteLine("Tahun Pembuatan: {0}", thnPembuatan);
            Console.WriteLine("Nilai Kelayakan: {0}", kondisi);
            // memberikan objek saat ini
            // sebagai argumen ke sebuah method
            Console.WriteLine("Kelayakan: {0}", UjiKelayakan.CekKelayakan(this));
        }
    }
    class UjiKelayakan
    {
        public static string kelayakan;
        public static string CekKelayakan(Mobil mobil)
        {
            // Salah satu field dari objek saat ini
            // digunakan untuk perbandingan nilai
            if (mobil.kondisi < 60)
            {
                kelayakan = "Tidak Layak Jalan!";
            }
            else
            {
                kelayakan = "Masih Layak Jalan!";
            }
            return kelayakan;
        }
    }
}