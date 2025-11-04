namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
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
                    try
                    {
                        Math.Round(operand1 / operand2, 4);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Are you trying to break the world?");
                        return 0;
                    }
                    return Math.Round(operand1 / operand2, 4);
                default:
                    MessageBox.Show("That's not math. Stop it");
                    return 0;
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal newOperand1 = Convert.ToDecimal(txtOperand1.Text);
                decimal newOperand2 = Convert.ToDecimal(txtOperand2.Text);
                string newOperator = txtOperator.Text;
                decimal result = Calculate(newOperand1, newOperator, newOperand2);
                txtResult.Text = result.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Are those even numbers?");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("What is this? A number for ants?");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "You broke it... I don't even know how.\n\n" +
                    $"Error: { ex.Message}\n\n Stack Trace: \n{ ex.StackTrace}",
                    "Exception"
                    );
                return;
            }
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
