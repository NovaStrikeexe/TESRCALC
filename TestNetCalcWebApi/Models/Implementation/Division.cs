using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    public class Division : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a / b;
        }
    }
}