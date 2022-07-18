using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalcWebApi.Models
{
    /**
    * MathOpertion - Интерфейс для всех имеющихся и будущих математических операций
    */
    public interface MathOpertion
    {
        double CalculateResult(double a, double b);
    }
}