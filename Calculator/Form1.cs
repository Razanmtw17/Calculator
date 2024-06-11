using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string equation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            equation += label1.Text;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            equation += label1.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            equation += label1.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            equation += label1.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            equation += label1.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            equation += label1.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            equation += label1.Text;
        }

        private void eught_Click(object sender, EventArgs e)
        {
            label1.Text += "8"; 
            equation += label1.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            equation += label1.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if(equation == "")
            {
                MessageBox.Show("please enter a valid number.");
            }
            else
            {
                label1.Text += "0";
                equation += label1.Text;
            }
            
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show("equation cant start with operator");
            }
            else
            {
                char last = equation.Last();
                if( last == '*' || last== '/' || last == '-' || last == '+')
                {
                    MessageBox.Show("cant enter 2 operands togather");
                }
                else
                {
                    label1.Text += "/";
                    equation += label1.Text;
                }
                
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show("equation cant start with operator");
            }
            else
            {
                char last = equation.Last();
                if (last == '*' || last == '/' || last == '-' || last == '+')
                {
                    MessageBox.Show("cant enter 2 operands togather");
                }
                else
                {
                    label1.Text += "*";
                    equation += label1.Text;
                }
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show("equation cant start with operator");
            }
            else
            {
                char last = equation.Last();
                if (last == '*' || last == '/' || last == '-' || last == '+')
                {
                    MessageBox.Show("cant enter 2 operands togather");
                }
                else
                {
                    label1.Text += "-";
                    equation += label1.Text;
                }
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show("equation cant start with operator");
            }
            else
            {
                char last = equation.Last();
                if (last == '*' || last == '/' || last == '-' || last == '+')
                {
                    MessageBox.Show("cant enter 2 operands togather");
                }
                else
                {
                    label1.Text += "+";
                    equation += label1.Text;
                }
            }
        }

        private void equall_Click(object sender, EventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show("equation cant start with operator");
            }
            else
            {
                char last = equation.Last();
                if (last == '*' || last == '/' || last == '-' || last == '+')
                {
                    MessageBox.Show("cant enter 2 operands togather");
                }
                else
                {
                    label1.Text += "=";
                    equation += label1.Text;
                    MessageBox.Show("res"+ (1+2));

                }
            }

        }
    }
}
