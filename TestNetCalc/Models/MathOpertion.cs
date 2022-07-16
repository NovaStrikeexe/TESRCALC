using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalc.Models
{
    public interface MathOpertion
    {
        double CalculateResult(double a, double b);
    }
}