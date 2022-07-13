using System;
using TestNetCalcWebApi.Models;
using TestNetCalcWebApi.Models.Implementation;

namespace TestNetCalcWebApi.Services
{
    public class AllOpCalculatorService
    {
        public string Execute(MathExpression mathExpression)
        {
            Addition addition = new Addition();
            Division division = new Division();
            Multiplication multiplication = new Multiplication();
            Subtraction subtraction = new Subtraction();
            try
            {
                if (mathExpression.NumberTwo == "")
                {
                    return mathExpression.NumberOne + mathExpression.TypeOperation;
                }
                switch (mathExpression.TypeOperation)
                {
                    case '+':
                        return addition.CalculateResult(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case '-':
                        return subtraction.CalculateResult(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case '*':
                        return multiplication.CalculateResult(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case '/':
                        return division.CalculateResult(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    default:
                        return "Unknown expression";
                }
            }
            catch (System.Exception)
            {
                return "System Error";
            }
        }
    }

}
