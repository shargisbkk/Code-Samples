using System.Drawing.Text;
using System.Text;

namespace WinFormsApp1
{

    public partial class frmCalculator : Form
    {
        Calculator calc = new Calculator();

        string lastPressed = "";
        bool isOperationPerformed = false;


        public frmCalculator()
        {
            InitializeComponent();
            rtxtDisplay.Text = "0";
        }

        public void numb_Click(object sender, EventArgs e)
        {
            if (rtxtDisplay.Text == "0" || isOperationPerformed == true)
                rtxtDisplay.Clear();

            Button clickedButton = (Button)sender;
            rtxtDisplay.Text += clickedButton.Text;

            isOperationPerformed = false;
            lastPressed = clickedButton.Text;
        }

        public void set_Operand(object sender, EventArgs e)
        {
            Button operandButton = (Button)sender;
            string operation = operandButton.Text;

            if (lastPressed == operation)
            {
                double result = calc.RepeatLast();
                rtxtDisplay.Text = result.ToString();
                isOperationPerformed = true;
            }
            else
            {
                calc.SetOperation(operation, double.Parse(rtxtDisplay.Text));
                isOperationPerformed = true;
            }

            lastPressed = operation;
        }

        public void calculate(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double result = 0;

            try
            {
                if (lastPressed == "=")
                {
                    result = calc.RepeatLast();
                }
                else
                {
                    double secondValue = double.Parse(rtxtDisplay.Text);
                    result = calc.Calculate(secondValue);
                }
                rtxtDisplay.Text = result.ToString();
                lastPressed = btn.Text;
            }
            catch (DivideByZeroException) // catch the rethrown exception
            {
                MessageBox.Show("Error: Cannot divide by zero.");
                rtxtDisplay.Text = "0";
            }
            catch // catch any unknown exceptions
            {
                MessageBox.Show("Error in calculations.");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Clear();
            rtxtDisplay.Text = "0";
            lastPressed = "";
            isOperationPerformed = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (rtxtDisplay.Text.Length > 1)
            {
                rtxtDisplay.Text = rtxtDisplay.Text.Substring(0, rtxtDisplay.Text.Length - 1);
            }
            else
            {
                rtxtDisplay.Text = "0";
            }
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            double.TryParse(rtxtDisplay.Text, out double value);
            rtxtDisplay.Text = (-value).ToString();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double.TryParse(rtxtDisplay.Text, out double value);
            value = calc.squareRoot(value);
            rtxtDisplay.Text = value.ToString();
        }

        private void btnReciprical_Click(object sender, EventArgs e)
        {
            double.TryParse(rtxtDisplay.Text, out double value);
            value = calc.reciprical(value);
            rtxtDisplay.Text = value.ToString();
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String buttonText = btn.Text;

            // if the user enters a decimal without first entering a number
            if (isOperationPerformed)
            {
                rtxtDisplay.Clear();
                rtxtDisplay.Text = "0";
                isOperationPerformed = false;
            }

            // if it doesn't contain a "." do this
            if (!rtxtDisplay.Text.Contains("."))
            {
                if (rtxtDisplay.Text == "" || rtxtDisplay.Text == "0")
                    rtxtDisplay.Text = "0.";
                else
                    rtxtDisplay.Text += buttonText;

                lastPressed = buttonText;

            }
        }
    }
}
