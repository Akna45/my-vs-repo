using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign() // untuk mengkustomisasi penampilan secara mudah
        {
            // agar submenu tidak terlihat saat awal-awal membuka
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolSubMenu.Visible = false;
            // ...
        }
        private void hideSubMenu() // untuk menyembunyikan submenu
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false; // jika submenu terlihat, maka atur submenu jadi tak terlihat
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolSubMenu.Visible == true)
                panelToolSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu) // untuk memunculkan submenu/ mengganti penampakan submenu
        { // menggunakan perimeter, submenu yang kamu klik sekarang akan membuatnya terlihat dan otomatis membuat submenu yang lain tak terlihat (tergantung btn apa yang kau klik)
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } // jika submenu tak terlihat, libatkan hideSub untuk mencari submenu yang terbuka dan menutupnya, lalu buat submenu sekarang terliat
            else // jika submenu terlihat, buat submenu tak terlihat
                subMenu.Visible = false;
            // digunakan ketika di-klik atau sebuah event terjadi
        }

        private void mediaBtn_Click(object sender, EventArgs e) // melakukan aksi ketika diklik
        {
            showSubMenu(panelMediaSubmenu); // perlihatkan submenu ketika diklik
        }
        private void btnMenuSubMenu_click(object sender, EventArgs e) // melakukan aksi ketika diklik
        {
            openChildPanel(new Form2());
            hideSubMenu(); // menyembunyikan submenu ketika diklik
        }
        // sisanya sama ya
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnMenuSidePanel_click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolSubMenu);
        }
        private void btnToolSidePanel_click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null; // variabel awal form
        private void openChildPanel(Form childForm) // method untuk membuka form dan kustomisasi-nya
        {
            if(activeForm!=null) // jika value variabel aF tidak null
                activeForm.Close(); // tutup form-nya
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm); // menambah form
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildPanel(new Form3());
        }
    }
}

// timestamp : 16:13