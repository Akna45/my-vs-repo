using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double firstNum, secondNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";
            if (b.Text == ".") 
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            String f, s;
            s = Convert.ToString(secondNum);
            f = Convert.ToString(firstNum);

            s = "";
            f = "";
        }

        private void Operational_Func(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            firstNum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void btn_BS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btn_PM_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            secondNum = Double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "×":
                    txtDisplay.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "÷":
                    txtDisplay.Text = Convert.ToString(firstNum / secondNum);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
