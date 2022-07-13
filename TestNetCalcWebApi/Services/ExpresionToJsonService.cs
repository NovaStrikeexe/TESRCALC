using System;
using System.Text;
using System.Text.Json;
using TestNetCalcWebApi.Models;

namespace TestNetCalcWebApi.Services
{
    public class ExpresionToJsonService
    {
        public static string ExpresionToJson(string expression)
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
            return JsonSerializer.Serialize<MathExpression>(
                new MathExpression
                {
                    NumberOne = numberOne.ToString(),
                    NumberTwo = numberTwo.ToString(),
                    TypeOperation = TypeOperation
                });
        }
    }
}