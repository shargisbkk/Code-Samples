using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Calculator
    {
        public double CurrentValue { get; private set; }
        public double LastValue { get; private set; }
        public string Operation { get; private set; }

        public Calculator() 
        {
            CurrentValue = 0;
            LastValue = 0;
            Operation = "";
        }

        public void SetOperation(string operation, double currentValue)
        {
            Operation = operation;
            CurrentValue = currentValue;
        }

        public double Calculate(double secondValue)
        {
            double result = 0;

            try
            {
                switch (Operation)
                {
                    case "+":
                        result = CurrentValue + secondValue;
                        break;
                    case "-":
                        result = CurrentValue - secondValue;
                        break;
                    case "*":
                        result = CurrentValue * secondValue;
                        break;
                    case "/":
                        if (secondValue == 0)
                            throw new DivideByZeroException();
                        result = CurrentValue / secondValue;
                        break;
                    default:
                        throw new InvalidOperationException("No operation set.");
                }

                LastValue = secondValue;
                CurrentValue = result;
                return result;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }

        public double RepeatLast()
        {
            return Calculate(LastValue);
        }

        public void Clear()
        {
            CurrentValue = 0;
            LastValue = 0;
            Operation = "";
        }

        public double squareRoot (double value)
        {
            double result = 0;
            try
            {
                if (value < 0)
                    throw new InvalidOperationException();
                result = Math.Sqrt(value);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error: This number has no squareroot.");
            }
            return result;
        }

        public double reciprical (double value)
        {
            double result = 0;
            try
            {
                if (value == 0)
                    throw new DivideByZeroException();
                result = (1 / value);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Cannot divide by 0.");
            }
            return result;
        }
    }
}
