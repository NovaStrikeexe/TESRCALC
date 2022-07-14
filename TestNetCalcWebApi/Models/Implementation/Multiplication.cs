using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    public class Multiplication : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a * b;
        }
    }
}