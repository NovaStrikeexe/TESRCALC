using System;
using TestNetCalcWebApi.Models;
using TestNetCalcWebApi.Models.Implementation;

namespace TestNetCalcWebApi.Services
{
    public class AllOpCalculatorService
    {
        public double Execute(MathExpression mathExpression)
        {
            Addition addition = new Addition();
            Division division = new Division();
            Multiplication multiplication = new Multiplication();
            Subtraction subtraction = new Subtraction();
            try
            {
                if (mathExpression.NumberTwo.ToString() == "")
                {
                    return mathExpression.NumberOne;
                }
                switch (mathExpression.TypeOperation)
                {
                    case '+':
                        return addition.CalculateResult(mathExpression.NumberOne, mathExpression.NumberTwo);
                    case '-':
                        return subtraction.CalculateResult(mathExpression.NumberOne, mathExpression.NumberTwo);
                    case '*':
                        return multiplication.CalculateResult(mathExpression.NumberOne, mathExpression.NumberTwo);
                    case '/':
                        return division.CalculateResult(mathExpression.NumberOne, mathExpression.NumberTwo);
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
