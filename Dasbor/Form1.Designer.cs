
namespace Dasbor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnPengaturan = new System.Windows.Forms.Button();
            this.btnHubungi = new System.Windows.Forms.Button();
            this.btnKalender = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnDasbor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnPengaturan);
            this.panel1.Controls.Add(this.btnHubungi);
            this.panel1.Controls.Add(this.btnKalender);
            this.panel1.Controls.Add(this.btnAnalisis);
            this.panel1.Controls.Add(this.btnDasbor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 537);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.pnlNav.Location = new System.Drawing.Point(3, 170);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 3;
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.FlatAppearance.BorderSize = 0;
            this.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengaturan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPengaturan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.btnPengaturan.Image = global::Dasbor.Properties.Resources.settings;
            this.btnPengaturan.Location = new System.Drawing.Point(0, 505);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Size = new System.Drawing.Size(289, 34);
            this.btnPengaturan.TabIndex = 2;
            this.btnPengaturan.Text = "Pengaturan";
            this.btnPengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPengaturan.UseVisualStyleBackColor = true;
            this.btnPengaturan.Click += new System.EventHandler(this.button3_Click);
            this.btnPengaturan.Leave += new System.EventHandler(this.btnPengaturan_Leave);
            // 
            // btnHubungi
            // 
            this.btnHubungi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHubungi.FlatAppearance.BorderSize = 0;
            this.btnHubungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHubungi.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHubungi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.btnHubungi.Image = global::Dasbor.Properties.Resources.Conact;
            this.btnHubungi.Location = new System.Drawing.Point(0, 248);
            this.btnHubungi.Name = "btnHubungi";
            this.btnHubungi.Size = new System.Drawing.Size(289, 34);
            this.btnHubungi.TabIndex = 2;
            this.btnHubungi.Text = "Hubungi";
            this.btnHubungi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHubungi.UseVisualStyleBackColor = true;
            this.btnHubungi.Click += new System.EventHandler(this.button4_Click);
            this.btnHubungi.Leave += new System.EventHandler(this.btnHubungi_Leave);
            // 
            // btnKalender
            // 
            this.btnKalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKalender.FlatAppearance.BorderSize = 0;
            this.btnKalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalender.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.btnKalender.Image = global::Dasbor.Properties.Resources.calendar;
            this.btnKalender.Location = new System.Drawing.Point(0, 214);
            this.btnKalender.Name = "btnKalender";
            this.btnKalender.Size = new System.Drawing.Size(289, 34);
            this.btnKalender.TabIndex = 2;
            this.btnKalender.Text = "Kalender";
            this.btnKalender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKalender.UseVisualStyleBackColor = true;
            this.btnKalender.Click += new System.EventHandler(this.button2_Click);
            this.btnKalender.Leave += new System.EventHandler(this.btnKalender_Leave);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnalisis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.btnAnalisis.Image = global::Dasbor.Properties.Resources.diagram;
            this.btnAnalisis.Location = new System.Drawing.Point(0, 180);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(289, 34);
            this.btnAnalisis.TabIndex = 2;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            this.btnAnalisis.Leave += new System.EventHandler(this.btnAnalisis_Leave);
            // 
            // btnDasbor
            // 
            this.btnDasbor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDasbor.FlatAppearance.BorderSize = 0;
            this.btnDasbor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasbor.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDasbor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.btnDasbor.Image = global::Dasbor.Properties.Resources.home;
            this.btnDasbor.Location = new System.Drawing.Point(0, 146);
            this.btnDasbor.Name = "btnDasbor";
            this.btnDasbor.Size = new System.Drawing.Size(289, 34);
            this.btnDasbor.TabIndex = 2;
            this.btnDasbor.Text = "Dasbor";
            this.btnDasbor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDasbor.UseVisualStyleBackColor = true;
            this.btnDasbor.Click += new System.EventHandler(this.btnDasbor_Click);
            this.btnDasbor.Leave += new System.EventHandler(this.btnDasbor_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 146);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat Datang, Akna Mafaid Ilmi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UserName.Location = new System.Drawing.Point(120, 87);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 25);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Akna";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dasbor.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("YasashisaGothicBoldV2 bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(321, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dasbor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textBox1.Location = new System.Drawing.Point(581, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "  Carilah sesuatu...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(902, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(321, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 130);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pendapatan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(141)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rp. 69.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Detail dari 30 hari terakhir...";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDasbor;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnPengaturan;
        private System.Windows.Forms.Button btnHubungi;
        private System.Windows.Forms.Button btnKalender;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

