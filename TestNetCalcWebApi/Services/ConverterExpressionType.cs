using System.Text.Json;
using TestNetCalcWebApi.Models;
namespace TestNetCalcWebApi.Services
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