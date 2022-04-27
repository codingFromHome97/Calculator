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
    public partial class frmCalculator : Form
    {
        String operation = "";
        Double firstnum, secondnum;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textIO.Text == "0")
            {
                textIO.Text = "";
            }
            if (b.Text == ".")
            {
                if (!textIO.Text.Contains("."))
                {
                    textIO.Text = textIO.Text + b.Text;
                }
            } else
            {
                textIO.Text = textIO.Text + b.Text;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textIO.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textIO.Text = "0";
            String first, second;
            first = Convert.ToString(firstnum); // converting to string so we can change to empty string
            second = Convert.ToString(secondnum);

            first = "";
            second = "";
        }

        private void Operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = Double.Parse(textIO.Text);
            operation = b.Text;
            textIO.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textIO.Text.Length > 0)
            {
                textIO.Text = textIO.Text.Remove(textIO.Text.Length - 1, 1);
            }

            if (textIO.Text == "0")
            {
                textIO.Text = "0";
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textIO.Text.Contains("-"))
            {
                textIO.Text = textIO.Text.Remove(0, 1);
            } else
            {
                textIO.Text = "-" + textIO.Text;
            }
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            secondnum = double.Parse(textIO.Text);
            switch (operation)
            {
                case "+":
                    textIO.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    textIO.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    textIO.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "÷":
                    if (secondnum > 0)
                    {
                        textIO.Text = Convert.ToString(firstnum / secondnum);
                        break;
                    } else
                    {
                        textIO.Text = "Invalid Input: Tried to Divide By 0";
                        Console.WriteLine($"Dividing by 0 error");
                        break;
                    }
                default:
                    break;
            }
        }

        private void buttonSquared_Click(object sender, EventArgs e)
        {
            double resultPow;
            if (textIO.Text == "")
            {
                Console.WriteLine($"No value to square");
            } else
            {
                Double current = Double.Parse(textIO.Text);
                resultPow = Math.Pow(current, 2);
                String resultString = resultPow.ToString();
                textIO.Text = resultString;
            }
            
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            String currentString = textIO.Text;
            double currentDouble = Double.Parse(currentString);
            double sqrt = Math.Sqrt(currentDouble);
            textIO.Text = sqrt.ToString();
        }

        // executed when our program first starts
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyPress += frmCalculator_KeyPress;
        }

        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 42: 
                case 43:
                case 45:
                case 47:
                    firstnum = Double.Parse(textIO.Text);
                    operation = e.KeyChar.ToString();
                    textIO.Text = "";
                    break;
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                    if (textIO.Text == "0")
                    {
                        textIO.Text = textIO.Text.Remove(textIO.Text.Length - 1, 1);
                        textIO.Text += e.KeyChar.ToString();
                    } else
                    {
                        textIO.Text += e.KeyChar.ToString();
                    }
                    break;
                case 61:
                    secondnum = double.Parse(textIO.Text);
                    if (operation == "+")
                    {
                        textIO.Text = Convert.ToString(firstnum + secondnum);
                    } else if (operation == "-")
                    {
                        textIO.Text = Convert.ToString(firstnum - secondnum);
                    } else if (operation == "*"){
                        textIO.Text = Convert.ToString(firstnum * secondnum);
                    } else if (operation == "/")
                    {
                        if (secondnum > 0)
                        {
                            textIO.Text = Convert.ToString(firstnum / secondnum);
                        } else
                        {
                            textIO.Text = "Invalid operation: divide by 0";
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
