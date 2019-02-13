using System;

namespace Example
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int sFirstNumber { get; set; }
        public int sSecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtract()
        {
            return sFirstNumber - sSecondNumber;
        }
    }
}
