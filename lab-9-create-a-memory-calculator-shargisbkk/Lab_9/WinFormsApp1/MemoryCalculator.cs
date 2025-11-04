using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MemoryCalculator : Calculator
    {
        public double memoryValue { get; set; }
        public MemoryCalculator()
        {
            memoryValue = 0;
        }
        public void AddToMemory(double value)
        {
            memoryValue += value;
        }
        public void MemoryClear()
        {
            memoryValue = 0;
        }
    }
}
