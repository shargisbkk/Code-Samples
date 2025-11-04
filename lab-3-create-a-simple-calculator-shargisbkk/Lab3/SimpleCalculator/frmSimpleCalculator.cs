namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }
        private string GetOperator1()
        {
            return txtOperator.Text;
        }
        private decimal GetOperand1()
        {
            return Convert.ToDecimal(txtOperand1.Text);
        }
        private decimal GetOperand2()
        {
            return Convert.ToDecimal(txtOperand2.Text);
        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            switch (operator1)
            {
                case "+":
                    return Math.Round(operand1 + operand2, 4);
                case "-":
                    return Math.Round(operand1 - operand2, 4);
                case "*":
                    return Math.Round(operand1 * operand2, 4);
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return 0;
                    }
                    return Math.Round(operand1 / operand2, 4);
                default:
                    MessageBox.Show("Invalid operator. Please use +, -, *, or /.");
                    return 0;
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal newOperand1 = GetOperand1();
            string newOperator = GetOperator1();
            decimal newOperand2 = GetOperand2();
            decimal result = Calculate(newOperand1, newOperator, newOperand2);
            txtResult.Text = result.ToString();
            txtOperand1.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
