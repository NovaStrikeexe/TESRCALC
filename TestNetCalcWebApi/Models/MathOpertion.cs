using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalcWebApi.Models
{
    public interface MathOpertion
    {
        string CalculateResult(double a, double b);
    }
}