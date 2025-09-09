using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentInput = "0";
        private string previousInput = "";
        private string operation = "";
        private bool isOperationPressed = false;
        private const int MaxDigits = 11;

        public Form1()
        {
            InitializeComponent();
            input_txtbox.Text = "0";
            textBox1.Text = "0";
        }

        private void UpdateInputTextBox()
        {
            input_txtbox.Text = currentInput;
        }

        private void UpdatePrevTextBox()
        {
            textBox1.Text = previousInput;
        }

        private void ClearErrorIfNeeded()
        {
            if (currentInput == "Error")
            {
                currentInput = "";
            }
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            ClearErrorIfNeeded();

            var btn = sender as Button;
            string num = btn.Text;

            int digitCount = currentInput.Replace(".", "").Replace("-", "").Length;

            if (digitCount >= MaxDigits && !isOperationPressed)
            {
                return;
            }

            if (currentInput == "0" || isOperationPressed || currentInput == "")
            {
                currentInput = num;
                isOperationPressed = false;
            }
            else
            {
                currentInput += num;
            }
            UpdateInputTextBox();
        }

        private void period_Click(object sender, EventArgs e)
        {
            ClearErrorIfNeeded();

            int digitCount = currentInput.Replace(".", "").Replace("-", "").Length;
            if (digitCount >= MaxDigits && !isOperationPressed)
            {
                return;
            }

            if (isOperationPressed || currentInput == "Error" || currentInput == "")
            {
                currentInput = "0.";
                isOperationPressed = false;
            }
            else if (!currentInput.Contains("."))
            {
                currentInput += ".";
            }
            UpdateInputTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentInput = "0";
            previousInput = "";
            operation = "";
            isOperationPressed = false;
            UpdateInputTextBox();
            UpdatePrevTextBox();
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            ClearErrorIfNeeded();

            if (currentInput.Length > 1)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                if (currentInput == "" || currentInput == "-")
                    currentInput = "0";
            }
            else
            {
                currentInput = "0";
            }
            UpdateInputTextBox();
        }

        private void mod_btn_Click(object sender, EventArgs e)
        {
            SetOperation("%");
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            SetOperation("x");
        }

        private void subt_btn_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        private void SetOperation(string op)
        {
            if (!string.IsNullOrEmpty(operation) && !isOperationPressed)
            {
                Calculate();
            }
            previousInput = currentInput + " " + op;
            operation = op;
            isOperationPressed = true;
            UpdatePrevTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation) && (string.IsNullOrEmpty(currentInput) || currentInput == "0"))
            {
                currentInput = "0";
                UpdateInputTextBox();
                previousInput = "";
                UpdatePrevTextBox();
                return;
            }

            if (string.IsNullOrEmpty(operation) && !string.IsNullOrEmpty(currentInput) && currentInput != "Error")
            {
                UpdateInputTextBox();
                previousInput = "";
                UpdatePrevTextBox();
                return;
            }

            Calculate();
            operation = "";
            previousInput = "";
            UpdatePrevTextBox();
        }

        private void Calculate()
        {
            try
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                if (string.IsNullOrEmpty(previousInput))
                {
                    UpdateInputTextBox();
                    return;
                }

                num1 = double.Parse(previousInput.Split(' ')[0]);
                num2 = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "x":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            currentInput = "Error";
                            UpdateInputTextBox();
                            return;
                        }
                        result = num1 / num2;
                        break;
                    case "%":
                        result = num1 % num2;
                        break;
                }
                currentInput = result.ToString();
                UpdateInputTextBox();
            }
            catch
            {
                currentInput = "Error";
                UpdateInputTextBox();
            }
        }

        private void num0_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num1_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num2_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num3_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num4_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num5_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num6_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num7_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num8_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void num9_Click(object sender, EventArgs e) => NumButton_Click(sender, e);
        private void input_textbox(object sender, EventArgs e) { }
        private void prevnum_textbox(object sender, EventArgs e) { }
    }
}
