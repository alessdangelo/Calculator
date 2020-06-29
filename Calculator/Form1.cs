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
        double valueOne; // Contain the first value entered
        double valueTwo; //Contain the second value entered
        string operationPerformed = ""; //String to know what operation to perform

        public Form1()
        {
            InitializeComponent();
            textBoxInput.MaxLength = 16;
        }

        private void button1_Click(object sender, EventArgs e) // Add 1 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 1;
            }

        }

        private void button2_Click(object sender, EventArgs e) // Add 2 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 2;
            }

        }

        private void button3_Click(object sender, EventArgs e) // Add 3 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 3;
            }

        }

        private void button4_Click(object sender, EventArgs e) // Add 4 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 4;
            }

        }

        private void button5_Click(object sender, EventArgs e) // Add 5 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 5;
            }

        }

        private void button6_Click(object sender, EventArgs e) // Add 6 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 6;
            }

        }

        private void button7_Click(object sender, EventArgs e) // Add 7 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 7;
            }

        }

        private void button8_Click(object sender, EventArgs e) // Add 8 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 8;
            }

        }

        private void button9_Click(object sender, EventArgs e) // Add 9 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0")
                    textBoxInput.Text = "";
                textBoxInput.Text = textBoxInput.Text + 9;
            }

        }

        private void button0_Click(object sender, EventArgs e) // Add 0 to textBoxInput.Text
        {
            if (textBoxInput.TextLength < 16)
            {
                if (textBoxInput.Text == "0") //If already == 0, doesn't change
                {
                    textBoxInput.Text = "0";
                }
                else
                    textBoxInput.Text = textBoxInput.Text + 0;
            }

        }

        private void buttonDot_Click(object sender, EventArgs e) // add a "."
        {
            if (!textBoxInput.Text.Contains("."))
                textBoxInput.Text = textBoxInput.Text + ".";
        }

        private void buttonPlus_Click(object sender, EventArgs e) // perform addition
        {
            label1.Text = textBoxInput.Text + " + ";
            valueOne = Convert.ToDouble(textBoxInput.Text);
            textBoxInput.Text = "0";
            operationPerformed = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e) // perform substraction
        {
            label1.Text = textBoxInput.Text + " - ";
            valueOne = Convert.ToDouble(textBoxInput.Text);
            textBoxInput.Text = "0";
            operationPerformed = "-";
        }

        private void buttonEqual_Click(object sender, EventArgs e) // get the result from the current calculation
        {
            label1.Text += textBoxInput.Text;
            valueTwo = Convert.ToDouble(textBoxInput.Text);
            switch (operationPerformed)
            {
                case "+":
                    textBoxInput.Text = Convert.ToString(valueOne + valueTwo);
                    break;
                case "-":
                    textBoxInput.Text = Convert.ToString(valueOne - valueTwo);
                    break;
                case "*":
                    textBoxInput.Text = Convert.ToString(valueOne * valueTwo);
                    break;
                case "/":
                    textBoxInput.Text = Convert.ToString(valueOne / valueTwo);
                    break;
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e) // perform multiply
        {
            label1.Text = textBoxInput.Text + " * ";
            valueOne = Convert.ToDouble(textBoxInput.Text);
            textBoxInput.Text = "0";
            operationPerformed = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e) // perform division
        {
            label1.Text = textBoxInput.Text + " / ";
            valueOne = Convert.ToDouble(textBoxInput.Text);
            textBoxInput.Text = "0";
            operationPerformed = "/";
        }

        private void buttonClearError_Click(object sender, EventArgs e) //Delete the current input
        {
            textBoxInput.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e) //Reset the calculator
        {
            textBoxInput.Text = "0";
            label1.Text = "0";
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e) // Prevents to type any character that isn't a number
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)  //Capture the keys from the numpad
            {
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    button3_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    button4_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    button5_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    button6_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    button7_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    button8_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    button9_Click(sender, e);
                    break;
                case Keys.NumPad0:
                    button0_Click(sender, e);
                    break;
                case Keys.Delete:
                    buttonClear_Click(sender, e);
                    break;
                case Keys.Back:
                    buttonClearError_Click(sender, e);
                    break;
                case Keys.Enter:
                    buttonEqual_Click(sender, e);
                    break;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            switch (e.KeyChar) //Capture the *, /, - and + keys
            {
                case (char)42:
                    buttonMultiply_Click(sender, e);
                    break;
                case (char)47:
                    buttonDivide_Click(sender, e);
                    break;
                case (char)45:
                    buttonMinus_Click(sender, e);
                    break;
                case (char)43:
                    buttonPlus_Click(sender, e);
                    break;
            }
        }
    }
}
