using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalc.Models.Implementation
{
    public class Division : MathOpertion
    {
        public string Calculate(double a, double b)
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