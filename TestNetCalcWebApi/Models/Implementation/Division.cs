using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    public class Division : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            try
            {
               return a / b;
            }
            catch (DivideByZeroException)
            {
                return 99999999999.0;
            }

        }
    }
}