using Xunit;
using TestNetCalcWebApi.Models;
using TestNetCalcWebApi.Services;
namespace TestNetCalcWebApi.Tests
{
    public class ReturnResultOfExpessionXUnit
    {

        [Fact]
        public void ReturnResultOfAdditionExpessionPass()
        {
            MathExpression mathExpression = new MathExpression();
            mathExpression.NumberOne = 450;
            mathExpression.NumberTwo = 1;
            mathExpression.TypeOperation = '+';
            Assert.Equal(451, BaseCalculatorService.ReturnResultOfExpession(mathExpression));
        }
        [Fact]
        public void ReturnResultOfMultiplicationExpessionPass()
        {
            MathExpression mathExpression = new MathExpression();
            mathExpression.NumberOne = 450;
            mathExpression.NumberTwo = 1;
            mathExpression.TypeOperation = '*';
            Assert.Equal(450, BaseCalculatorService.ReturnResultOfExpession(mathExpression));
        }
    }
}