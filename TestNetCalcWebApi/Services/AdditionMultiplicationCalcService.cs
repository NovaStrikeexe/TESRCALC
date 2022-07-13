using System;
using TestNetCalcWebApi.Models;
using TestNetCalcWebApi.Models.Implementation;


namespace TestNetCalcWebApi.Services
{
    public class AdditionMultiplicationCalcService
    {
        public static string Execute(MathExpression mathExpression)
        {
            Addition addition = new Addition();
            Multiplication multiplication = new Multiplication();
            if (mathExpression.NumberTwo == "")
            {
                return mathExpression.NumberOne + mathExpression.TypeOperation;
            }
            try
            {
                switch (mathExpression.TypeOperation)
                {
                    case '+':
                        return addition.CalculateResult(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case '*':
                        return multiplication.CalculateResult(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
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