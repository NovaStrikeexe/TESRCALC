﻿using System.Text;
using System.Text.Json;
using TestNetCalc.Models;

namespace TestNetCalc.Service
{
    public class CalculatorService
    {
        public static string ExpresionToJson(string expression)
        {
            StringBuilder NumberOne = new StringBuilder("", 8);
            StringBuilder NumberTwo = new StringBuilder("", 8);
            char TypeOperation = '\0';

            for (int i = 0; i <= expression.Length - 1; i++)
            {
                if (TypeOperation == '\0')
                {
                    if (expression[i] == '-' & NumberOne.Equals(""))
                    {
                        NumberOne.Append(expression[i]);
                    }
                    else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/' & !NumberOne.Equals(""))
                    {

                        TypeOperation = expression[i];
                    }
                    else
                    {
                        NumberOne.Append(expression[i]);
                    }
                }
                else
                {
                    NumberTwo.Append(expression[i]);
                }
            }
            return JsonSerializer.Serialize<MathExpression>(
                new MathExpression
                {
                    NumberOne = NumberOne.ToString(),
                    NumberTwo = NumberTwo.ToString(),
                    TypeOperation = TypeOperation
                });
        }
        public static MathExpression ConvertToExpressionType(string ExpressionJsonString)
        {
#nullable enable
            MathExpression? expression = JsonSerializer.Deserialize<MathExpression>(ExpressionJsonString);
            return expression;
        }
        public static string ReturnResultOfExpession(string expression)
        {
            string exp = ExpresionToJson(expression);
            MathExpression expr = ConvertToExpressionType(exp);
            BaseCalculator? BaseCalculator = new BaseCalculator();
            if (expr.NumberTwo.Equals(""))
            {
                return expression;
            }
            else
            {
                switch (expr.TypeOperation)
                {
                    case '+':
                        return BaseCalculator.Addition(expr.NumberOne, expr.NumberTwo);
                    case '-':
                        return BaseCalculator.Subtraction(expr.NumberOne, expr.NumberTwo);
                    case '*':
                        return BaseCalculator.Multiplication(expr.NumberOne, expr.NumberTwo);
                    case '/':
                        return BaseCalculator.Division(expr.NumberOne, expr.NumberTwo);
                    default:
                        return "Unknown expression";
                }
            }

        }
    }
}
