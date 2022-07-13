using TestNetCalc.Models;
namespace TestNetCalc.Services
{
    public class BaseCalculatorService 
    {
        public static string ReturnResultOfExpession(MathExpression mathExpression)
        {
            return AdditionMultiplicationCalcService.Execute(mathExpression);
        }
    }
}
