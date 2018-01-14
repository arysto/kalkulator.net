using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private string firstValue = null;

        private string secondValue = null;

        private string action = null;

        private bool chain = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            SetValue(1);
        }

        private void number2_Click(object sender, EventArgs e)
        {
            SetValue(2);
        }

        private void number3_Click(object sender, EventArgs e)
        {
            SetValue(3);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            SetValue(4);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            SetValue(5);
        }

        private void number6_Click(object sender, EventArgs e)
        {
            SetValue(6);
        }

        private void number7_Click(object sender, EventArgs e)
        {
            SetValue(7);
        }

        private void number8_Click(object sender, EventArgs e)
        {
            SetValue(8);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            SetValue(9);
        }

        private void number0_Click(object sender, EventArgs e)
        {
            SetValue(0);
        }

        private void SetValue(int number)
        {
            if (chain)
            {
                BreakChain();
            }

            if (action == null)
            {
                firstValue += number.ToString();
                textbox.Text = Convert.ToString(Convert.ToDouble(firstValue));
            }
            else
            {
                secondValue += number.ToString();
                textbox.Text = Convert.ToString(Convert.ToDouble(secondValue));
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            SetAction("+");
        }

        private void substract_Click(object sender, EventArgs e)
        {
            SetAction("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            SetAction("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            SetAction("/");
        }

        private void SetAction(string action)
        {
            if (this.action != action)
            {
                BreakChain();
            }

            textbox.Text = "0";

            this.action = action;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            double first = Convert.ToDouble(firstValue);
            double second = Convert.ToDouble(secondValue);
            double result = 0;
            switch (action)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    if (second == 0)
                    {
                        MessageBox.Show("Nie dzielimy przez 0");
                        ClearCalculator();
                        return;
                    }

                    result = first / second;
                    break;
            }

            if (!chain)
            {
                chain = true;
            }

            firstValue = result.ToString();
            textbox.Text = result.ToString();
        }

        private void BreakChain()
        {
            chain = false;
            secondValue = null;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        private void ClearCalculator()
        {
            firstValue = null;
            secondValue = null;
            textbox.Text = "0";
            action = null;
            chain = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
