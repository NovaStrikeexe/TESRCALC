using System;

namespace TestNetCalcWebApi.Models.Implementation
{
    /**
    *  Division - класс использующий интерфейс @MathOpertion для проведения операции деления двух чисел и вывода результата (В разработке)
    */
    public class Division : MathOpertion
    {
        public double CalculateResult(double a, double b)
        {
            return a / b;
        }
    }
}