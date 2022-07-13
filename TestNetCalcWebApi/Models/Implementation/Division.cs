using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    public class Division : MathOpertion
    {
        public string CalculateResult(double a, double b)
        {
            try
            {
                return Convert.ToString(a / b);
            }
            catch (DivideByZeroException)
            {
                return "Div by zero";
            }
        }
    }
}