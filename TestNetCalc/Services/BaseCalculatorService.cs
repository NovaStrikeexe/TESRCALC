using TestNetCalc.Models;
namespace TestNetCalc.Services
{
    public class BaseCalculatorService
    {
        public static double ReturnResultOfExpession(MathExpression mathExpression)
        {
            return AdditionMultiplicationCalcService.Execute(mathExpression);
        }
    }
}
