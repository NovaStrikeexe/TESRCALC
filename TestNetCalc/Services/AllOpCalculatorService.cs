using TestNetCalc.Models;
using TestNetCalc.Models.Implementation;

namespace TestNetCalc.Services
{
    public class AllOpCalculatorService
    {
        public class AdditionMultiplicationCalcService
        {
            public string Execute(MathExpression mathExpression)
            {
                Addition addition = new Addition();
                Division division = new Division();
                Multiplication multiplication = new Multiplication();
                Subtraction subtraction = new Subtraction();
                try
                {
                    switch (mathExpression.TypeOperation)
                    {
                        case '+':
                            return addition.Calculate(mathExpression.NumberOne, mathExpression.NumberTwo);
                        case '-':
                            return subtraction.Calculate(mathExpression.NumberOne, mathExpression.NumberTwo);
                        case '*':
                            return multiplication.Calculate(mathExpression.NumberOne, mathExpression.NumberTwo);
                        case '/':
                            return division.Calculate(mathExpression.NumberOne, mathExpression.NumberTwo);
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
}