using System;

namespace Example
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }

    public class CalculatorSubtract
    {
        public int SFirstNumber { get; set; }
        public int SSecondNumber { get; set; }

        public int Subtract()
        {
            return SFirstNumber - SSecondNumber;
        }

    }

}
