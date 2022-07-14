using System;
using System.Text;
using System.Text.Json;
using TestNetCalcWebApi.Models;

namespace TestNetCalcWebApi.Services
{
    public class ExpresionToMathExpressionService
    {
        public static MathExpression ExpresionToMathExpression(string expression)
        {
            StringBuilder numberOne = new StringBuilder("", 8);
            StringBuilder numberTwo = new StringBuilder("", 8);
            char TypeOperation = '\0';

            for (int i = 0; i <= expression.Length - 1; i++)
            {
                if (TypeOperation == '\0')
                {
                    if (expression[i] == '-' & numberOne.Equals(""))
                    {
                        numberOne.Append(expression[i]);
                    }
                    else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/' & !numberOne.Equals(""))
                    {

                        TypeOperation = expression[i];
                    }
                    else
                    {
                        numberOne.Append(expression[i]);
                    }
                }
                else
                {
                    numberTwo.Append(expression[i]);
                }
            }
            return new MathExpression
            {
                NumberOne = Convert.ToDouble(numberOne),
                NumberTwo = Convert.ToDouble(numberTwo),
                TypeOperation = TypeOperation
            };
        }
    }
}