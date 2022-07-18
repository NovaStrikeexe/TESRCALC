using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    /**
    *  Addition - класс использующий интерфейс @MathOpertion для проведения операции сложения двух чисел и вывода результата
    */
    public class Addition : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a + b;
        }
    }
}