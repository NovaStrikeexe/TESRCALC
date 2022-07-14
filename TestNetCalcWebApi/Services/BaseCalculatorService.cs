using TestNetCalcWebApi.Models;
namespace TestNetCalcWebApi.Services
{
    public class BaseCalculatorService 
    {
        public static double ReturnResultOfExpession(MathExpression mathExpression)
        {
            return AdditionMultiplicationCalcService.Execute(mathExpression);
        }
    }
}
