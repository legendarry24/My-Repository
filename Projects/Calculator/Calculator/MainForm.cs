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
    public partial class MainForm : Form
    {
        private double firstOperand;  // первый операнд
        private double secondOperand; // второй операнд

        // Определяет какая вычислительная операция будет выполняться
        public Operation Operation { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText(",");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputTextBox.AppendText("9");
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text;
            int length = inputTextBox.TextLength - 1;
            inputTextBox.Clear();

            //удалить последний символ из текстового поля
            for (int i = 0; i < length; i++)
            {
                inputTextBox.AppendText(text[i].ToString());
            }           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            Operation = Operation.Addition;
            label1.Text = firstOperand + "+";
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            Operation = Operation.Subtraction;
            label1.Text = firstOperand + "-";
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            Operation = Operation.Multiplication;
            label1.Text = firstOperand + "*";
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            Operation = Operation.Division;
            label1.Text = firstOperand + "/";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(inputTextBox.Text);

            switch (Operation)
            {
                case Operation.Addition:
                    inputTextBox.Text = (firstOperand + secondOperand).ToString();
                    break;

                case Operation.Subtraction:
                    inputTextBox.Text = (firstOperand - secondOperand).ToString();
                    break;

                case Operation.Multiplication:
                    inputTextBox.Text = (firstOperand * secondOperand).ToString();
                    break;

                case Operation.Division:
                    inputTextBox.Text = (firstOperand / secondOperand).ToString();
                    break;
            }

            label1.Text = string.Empty;
        }
    }
}