using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalc.Models.Implementation
{
    public class Addition : MathOpertion
    {
        public string Calculate(double a, double b)
        {
            return Convert.ToString(a + b);
        }
    }
}