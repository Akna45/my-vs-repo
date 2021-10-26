
namespace MyCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn_BS = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.btn_PM = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_Equals = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(318, 43);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_BS
            // 
            this.btn_BS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.btn_BS.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_BS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_BS.Location = new System.Drawing.Point(12, 74);
            this.btn_BS.Name = "btn_BS";
            this.btn_BS.Size = new System.Drawing.Size(75, 73);
            this.btn_BS.TabIndex = 1;
            this.btn_BS.Text = "";
            this.btn_BS.UseVisualStyleBackColor = false;
            this.btn_BS.Click += new System.EventHandler(this.btn_BS_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.BtnCE.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCE.Location = new System.Drawing.Point(93, 74);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(75, 73);
            this.BtnCE.TabIndex = 1;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.BtnC.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnC.Location = new System.Drawing.Point(174, 74);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(75, 73);
            this.BtnC.TabIndex = 1;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_PM
            // 
            this.btn_PM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.btn_PM.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_PM.Location = new System.Drawing.Point(255, 74);
            this.btn_PM.Name = "btn_PM";
            this.btn_PM.Size = new System.Drawing.Size(75, 73);
            this.btn_PM.TabIndex = 1;
            this.btn_PM.Text = "±";
            this.btn_PM.UseVisualStyleBackColor = false;
            this.btn_PM.Click += new System.EventHandler(this.btn_PM_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(255, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 73);
            this.button5.TabIndex = 1;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Operational_Func);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(174, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 73);
            this.button6.TabIndex = 1;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumericValue);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(93, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 73);
            this.button7.TabIndex = 1;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumericValue);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button8.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(12, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 73);
            this.button8.TabIndex = 1;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumericValue);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button9.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(255, 232);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 73);
            this.button9.TabIndex = 1;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Operational_Func);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button10.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(174, 232);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 73);
            this.button10.TabIndex = 1;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumericValue);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button11.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button11.Location = new System.Drawing.Point(93, 232);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 73);
            this.button11.TabIndex = 1;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NumericValue);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button12.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button12.Location = new System.Drawing.Point(12, 232);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 73);
            this.button12.TabIndex = 1;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.NumericValue);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button13.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button13.Location = new System.Drawing.Point(255, 311);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 73);
            this.button13.TabIndex = 1;
            this.button13.Text = "×";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Operational_Func);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button14.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Location = new System.Drawing.Point(174, 311);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 73);
            this.button14.TabIndex = 1;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.NumericValue);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button15.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button15.Location = new System.Drawing.Point(93, 311);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 73);
            this.button15.TabIndex = 1;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.NumericValue);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button16.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button16.Location = new System.Drawing.Point(12, 311);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 73);
            this.button16.TabIndex = 1;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.NumericValue);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button17.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button17.Location = new System.Drawing.Point(255, 390);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 73);
            this.button17.TabIndex = 1;
            this.button17.Text = "÷";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Operational_Func);
            // 
            // btn_Equals
            // 
            this.btn_Equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.btn_Equals.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equals.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Equals.Location = new System.Drawing.Point(174, 390);
            this.btn_Equals.Name = "btn_Equals";
            this.btn_Equals.Size = new System.Drawing.Size(75, 73);
            this.btn_Equals.TabIndex = 1;
            this.btn_Equals.Text = "=";
            this.btn_Equals.UseVisualStyleBackColor = false;
            this.btn_Equals.Click += new System.EventHandler(this.btn_Equals_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button19.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button19.Location = new System.Drawing.Point(93, 390);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 73);
            this.button19.TabIndex = 1;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.NumericValue);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(190)))));
            this.button20.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button20.Location = new System.Drawing.Point(12, 390);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 73);
            this.button20.TabIndex = 1;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.NumericValue);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::MyCalculator.Properties.Resources._1085726;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 478);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn_Equals);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_PM);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.btn_BS);
            this.Controls.Add(this.txtDisplay);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.NumericValue);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn_BS;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button btn_PM;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_Equals;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}

