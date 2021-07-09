using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dasbor
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDasbor_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDasbor.Height;
            pnlNav.Top = btnDasbor.Top;
            pnlNav.Left = btnDasbor.Left;
            btnDasbor.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalisis.Height;
            pnlNav.Top = btnAnalisis.Top;
            pnlNav.Left = btnAnalisis.Left;
            btnAnalisis.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnKalender.Height;
            pnlNav.Top = btnKalender.Top;
            pnlNav.Left = btnKalender.Left;
            btnKalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHubungi.Height;
            pnlNav.Top = btnHubungi.Top;
            pnlNav.Left = btnHubungi.Left;
            btnHubungi.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnKalender_Leave(object sender, EventArgs e)
        {
            btnKalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDasbor_Leave(object sender, EventArgs e)
        {
            btnDasbor.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalisis_Leave(object sender, EventArgs e)
        {
            btnAnalisis.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHubungi_Leave(object sender, EventArgs e)
        {
            btnHubungi.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPengaturan.Height;
            pnlNav.Top = btnPengaturan.Top;
            pnlNav.Left = btnPengaturan.Left;
            btnPengaturan.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPengaturan_Leave(object sender, EventArgs e)
        {
            btnPengaturan.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
