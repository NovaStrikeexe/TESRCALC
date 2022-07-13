using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    public class Subtraction : MathOpertion
    {
        public string CalculateResult(double a, double b)
        {
            return Convert.ToString(a - b);
        }
    }
}