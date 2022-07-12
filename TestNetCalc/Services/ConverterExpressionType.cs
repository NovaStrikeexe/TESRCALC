using System.Text.Json;
using TestNetCalc.Models;
namespace TestNetCalc.Services
{
    public class ConverterExpressionType
    {
        public static MathExpression JsonToExpressionType(string ExpressionJsonString)
        {
#nullable enable
            MathExpression? expression = JsonSerializer.Deserialize<MathExpression>(ExpressionJsonString);
            return expression;
        }
    }
}