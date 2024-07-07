using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = "";

       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zerobutton_Click(object sender, EventArgs e)
        {
           bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with zero");
            }
            else
            {
                label1.Text += "0";
                input += "0";
            }
        }

        private void onebutton_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            input += "1";
        }

        private void twobutton_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            input += "2";
        }

        private void threebutton_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            input += "3";
        }

        private void fourbutton_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            input += "4";
        }

        private void fivebutton_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            input += "5";
        }

        private void sixbutton_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            input += "6";
        }

        private void sevenbutton_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            input += "7";
        }

        private void eightbutton_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            input += "8";
        }

        private void ninebutton_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            input += "9";
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            input = "";
            label2.Text = "";
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with + ");
            }
            
            else
            {
                if (input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith("."))
                {
                    MessageBox.Show("Cant accept two experssion togather");
                }
                else
                {
                    label1.Text += " + ";
                    input += "+";
                }
               
            }
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with - ");
            }
            else
            {
                if (input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith("."))
                {
                    MessageBox.Show("Cant accept two experssion togather");
                }
                else
                {
                    label1.Text += " - ";
                    input += "-";
                }

            }
        }

        private void mulbutton_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with X ");
            }
            else
            {
                if (input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith("."))
                {
                    MessageBox.Show("Cant accept two experssion togather");
                }
                else
                {
                    label1.Text += " X ";
                    input += "*";
                }

            }
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with / ");
            }
            else
            {
                if (input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith("."))
                {
                    MessageBox.Show("Cant accept two experssion togather");
                }
                else
                {
                    label1.Text += " / ";
                    input += "/";
                }

            }
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with = ");
            }
            if (input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith("."))
            {
                MessageBox.Show("Cant accept two experssion togather");
            }
            else
            {
                label1.Text += " = ";
                label2.Text = label1.Text;
                label1.Text = "";
                
            }
        }

        private void dotbutton_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true)
            {
                MessageBox.Show("Cant start with . ");
            }
            else
            {
                if (input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith("."))
                {
                    MessageBox.Show("Cant accept two experssion togather");
                }
                else
                {
                    label1.Text += ".";
                    input += ".";
                }

            }
        }
    }
}
