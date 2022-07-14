using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    public class Addition : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a + b;
        }
    }
}