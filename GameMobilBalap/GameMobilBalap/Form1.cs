using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMobilBalap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
        }
        // method untuk
        void moveline (int speed)
        {
            // fungsinya adalah untuk mengulangi pattern jalannya.
            // jika y axis = 500 bertemu y axis = 500 lagi, maka method ini akan mengulangi-nya lagi
            if(pictureBox1.Top>=500)
            {pictureBox1.Top = 0;}
            else { pictureBox1.Top += speed; }
        }
    }
}
