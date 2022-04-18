using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMobilBalap // timestamp : 35:03 (taro timestamp disini biar gak lupa)
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // memulai komponen
            over.Visible = false; // teks game over tak terlihat di awal

        }
        void gameover() // method untuk gameover
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds)) // jika ketemu mobil lain
            {
                timer1.Enabled = false; // matikan timer
                over.Visible = true; // membuat tulisan gameover terlihat
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // yang membuat game-nya berjalan
        {
            moveline(gamespeed); // mengubah kecepatan jalan berdasarkan var. gamespeed
            enemy(gamespeed); // mengubah posisi musuh berdasarkan var. gamespeed
            gameover(); // melaksanakan method gameover
            coins(gamespeed); // mengubah posisi koin berdasarkan var. gamespeed
            dolarCollected(); // mengumpulkan koin dan menampilkannya di game
            speed(); // mengumpulkan jarak terjauh dan menampilkannya di game
            
        }

        int collectedDolar = 0;

        Random r = new Random(); // pengacak
        int x, y; // var. koordinat
        void enemy(int speed) // method untuk mobil musuh
        {
            if (enemy1.Top >= 500) // mengacak posisi musuh
            {
                x = r.Next(0,200); // mengacak koordinat posisi mobil
                enemy1.Location = new Point(x, 0); // ngespawn dan ngacak lokasi mobil musuh
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500) // mengacak posisi musuh
            {
                x = r.Next(0, 350); // mengacak koordinat posisi mobil
                enemy2.Location = new Point(x, 0); // ngespawn dan ngacak lokasi mobil musuh
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500) // mengacak posisi musuh
            {
                x = r.Next(0, 400); // mengacak koordinat posisi mobil
                enemy3.Location = new Point(x, 0); // ngespawn dan ngacak lokasi mobil musuh
            }
            else { enemy3.Top += speed; }
        }

        void coins(int speed) // method untuk dolar (skor di game ini)
        {
            if (coin1.Top >= 500) //
            {
                x = r.Next(25, 290); // mengacak koordinat posisi dolar
                coin1.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500) //
            {
                x = r.Next(40, 200); // mengacak koordinat posisi dolar
                coin2.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500) //
            {
                x = r.Next(50, 400); // mengacak koordinat posisi dolar
                coin3.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500) //
            {
                x = r.Next(30, 250); // mengacak koordinat posisi dolar
                coin4.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }
            else { coin4.Top += speed; }
        }

        void moveline (int speed)
        {
            // fungsinya adalah untuk mengulangi pattern jalannya.
            // jika y axis = 500 bertemu y axis = 500 lagi, maka method ini akan mengulangi-nya lagi
            if(pictureBox1.Top>=500)
            {pictureBox1.Top = 0;}
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }
        }

        void dolarCollected ()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedDolar++;
                label1.Text = "Dolar = " + collectedDolar.ToString();

                x = r.Next(20, 300); // mengacak koordinat posisi dolar dan menghilangkannya agar selanjutnya muncul
                coin1.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }
            
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedDolar++;
                label1.Text = "Dolar = " + collectedDolar.ToString();

                x = r.Next(20, 300); // mengacak koordinat posisi dolar
                coin2.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedDolar++;
                label1.Text = "Dolar = " + collectedDolar.ToString();

                x = r.Next(20, 300); // mengacak koordinat posisi dolar
                coin3.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedDolar++;
                label1.Text = "Dolar = " + collectedDolar.ToString();

                x = r.Next(20, 300); // mengacak koordinat posisi dolar
                coin4.Location = new Point(x, 0); // ngespawn dan ngacak lokasi dolar
            }
        }

        void speed()
        {
            int speed = gamespeed;
            speed++;

            label2.Text = "Kecepatan = " + speed.ToString();
        }

        int gamespeed = 0;

        
        // method untuk kendali mobil user
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
            {
                if(car.Left>0) // batas bisa belok
                    car.Left += -20; // membuat mobil belok kiri
            }
            if (e.KeyCode==Keys.Right)
            {
                if(car.Right<380) // batas bisa belok
                car.Left += 20; // membuat mobil belok kanan
            }
            if(e.KeyCode==Keys.Up)
            {
                if(gamespeed<300) // naikkan kecep. sampe 300
                { gamespeed++; } // menaikkan kecepatan
            }
            if(e.KeyCode==Keys.Down)
            {
                if(gamespeed>0) // menurunkan kecep. sampai 0
                { gamespeed--; } // menurunkan kecepatan
            }    

        }

        
    }
}

/* ISU
    tulis disini mengenai isu-mu dalam program ini :
        - ingin buat nabrak mobil tapi malah keliat nabrak kotak
        - gameover tapi masih bisa belok
        - belum betul betul nabrak udah G-O (mungkin karena bentuk kotak tersebut

    IDE :
    Tulis dibawah mengenai idemu dalam game ini :
        - tambahkan suara efek tabrakan dan horor (ketawa seram)
        - tambahkan restart game

*/