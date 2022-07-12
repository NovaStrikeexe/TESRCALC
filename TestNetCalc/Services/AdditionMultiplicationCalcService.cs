using TestNetCalc.Models;
using TestNetCalc.Models.Implementation;


namespace TestNetCalc.Services
{
    public class AdditionMultiplicationCalcService
    {
        public static string Execute(MathExpression mathExpression)
        {
            Addition addition = new Addition();
            Multiplication multiplication = new Multiplication();
            try
            {
                switch (mathExpression.TypeOperation)
                {
                    case '+':
                        return addition.Calculate(mathExpression.NumberOne, mathExpression.NumberTwo);
                    case '*':
                        return multiplication.Calculate(mathExpression.NumberOne, mathExpression.NumberTwo);
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