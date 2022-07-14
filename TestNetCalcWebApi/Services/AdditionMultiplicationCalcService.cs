using System;
using TestNetCalcWebApi.Models;
using TestNetCalcWebApi.Models.Implementation;


namespace TestNetCalcWebApi.Services
{
    public class AdditionMultiplicationCalcService
    {
        public static double Execute(MathExpression mathExpression)
        {
            Addition addition = new Addition();
            Multiplication multiplication = new Multiplication();
            if (mathExpression.NumberTwo.ToString() == "")
            {
                return mathExpression.NumberOne;
            }
            try
            {
                switch (mathExpression.TypeOperation)
                {
                    case '+':
                        return addition.CalculateResult(mathExpression.NumberOne, mathExpression.NumberTwo);
                    case '*':
                        return multiplication.CalculateResult(mathExpression.NumberOne, mathExpression.NumberTwo);
                    default:
                        return mathExpression.NumberOne;
                }
            }
            catch (System.Exception)
            {
                return mathExpression.NumberOne;
            }
        }
    }
}