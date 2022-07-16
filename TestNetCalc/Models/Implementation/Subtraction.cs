using System;

namespace TestNetCalc.Models.Implementation
{
    public class Subtraction : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a - b;
        }
    }
}