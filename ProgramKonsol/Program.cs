using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Contoh;
using Pembelajaran;

namespace ProgramKonsol
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //input
            int[,] matrix =
            {
                { 1, 2, 3, 4}, // row 0 values
                { 5, 6, 7, 8}, // row 1 values
            };

            //output
            Console.WriteLine("halo, ini adalah koding tertanggal : "+DateTime.Now);
            string firstDogName = null;
            Console.Write("Enter first dog name: ");
            firstDogName = Console.ReadLine();
            // Using a constructor to create a dog with specified name
            Dog firstDog = new Dog(firstDogName);
            // Using a constructor to create a dog wit a default name
            Dog secondDog = new Dog();
            Console.Write("Enter second dog name: ");
            string secondDogName = Console.ReadLine();
            // Using property to set the name of the dog
            secondDog.Name = secondDogName;
            // Creating a dog with a default name
            Dog thirdDog = new Dog();
            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
            Cat kucing1 = new Cat("","");
            kucing1.SayMiau();
            Console.ReadKey();
        }
    }
}
namespace Contoh
{
    // gunakan namespace ini untuk menaruh contoh class dari buku/referensi
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
    public class Cat
    {
        // Field name
        private string name;
        // Field color
        private string color;
        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }
        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }
        // Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
        }
    }
    // Class declaration
    public class Dog
    { // Opening bracket of the class body
    // Field declaration
        private string name;
        private int age;
        // Constructor declaration (peremeterless empty constructor)
        public Dog()
        {
        }
        // Another constructor declaration
        public Dog(string name)
        {
            this.name = name;
        }
        // Property declaration
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Method declaration (non-static)
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",
            name ?? "[unnamed dog]");
        }
        public int GetAge()
        {
            return age;
        }
    } // Closing bracket of the class body
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;
        // Intentionally deny instantiation of this class

        // Static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
namespace Pembelajaran
{
    static class Aritmatika
    {
        static int Tambah(int a, int b)
        {
            return a+b;
        }
    }
    static class Text
    {
        static void ReadFile(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}