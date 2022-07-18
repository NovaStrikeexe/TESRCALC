using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    /**
    *  Multiplication - класс использующий интерфейс @MathOpertion для проведения операции умножения двух чисел и вывода результата
    */
    public class Multiplication : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a * b;
        }
    }
}