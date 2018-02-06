using System;

namespace Calculator
{
    public class Calculator
    {
       public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
           Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
           Accumulator = a - b;
           return Accumulator;
        }

        public double Multiply(double a, double b)
        {
           Accumulator = a * b;
           return Accumulator;
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
           
            if (a < 0)
            {
                throw new ArgumentException("False");
            }
            return Accumulator;
        }

        public double Divide(double divend, double divisor)
        {
            Accumulator = divend / divisor;

            if (divisor == 0)
            {
                throw new ArgumentException("False");
            }
            return Accumulator;
        }
    }
}
