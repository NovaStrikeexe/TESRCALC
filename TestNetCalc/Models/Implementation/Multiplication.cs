using System;

namespace TestNetCalc.Models.Implementation
{
    public class Multiplication : MathOpertion
    {
        public string Calculate(double a, double b)
        {
            return Convert.ToString(a * b);
        }
    }
}