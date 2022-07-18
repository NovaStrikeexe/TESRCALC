using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    /**
    *  Subtraction - класс использующий интерфейс @MathOpertion для проведения операции вычитания двух чисел и вывода результата
    */
    public class Subtraction : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a - b;
        }
    }
}