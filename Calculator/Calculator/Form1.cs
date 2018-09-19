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
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void click(object sender,EventArgs e)
        {
            Button b = sender as Button;
            
            if (textBox1.Text == "0" && textBox1.Text != null && b.Text !="0")
            {
                textBox1.Text = b.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }
           

        }

        private void onClickOperator(object sender, EventArgs e)
        {
           
            Button b = sender as Button;
            if(b.Text == "+")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "+";
            }
            else if(b.Text == "-")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "-";
            }
            else if(b.Text == "*")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";

            }

            else if(b.Text == "/")
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "/";
            }
        }

       

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }



        Boolean callFirst = false;
        private void ndot_Click(object sender, EventArgs e)
        {
            if(callFirst == false)
            {
                textBox1.Text = textBox1.Text + ".";
                callFirst = true;

            }
           
        }

       

        private void nequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}
