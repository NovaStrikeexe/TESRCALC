using System;
using TestNetCalc.Models;
using TestNetCalc.Models.Implementation;

namespace TestNetCalc.Services
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
                    case "+":
                        return addition.Calculate(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case "-":
                        return subtraction.Calculate(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case "*":
                        return multiplication.Calculate(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
                    case "/":
                        return division.Calculate(Convert.ToDouble(mathExpression.NumberOne), Convert.ToDouble(mathExpression.NumberTwo));
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
