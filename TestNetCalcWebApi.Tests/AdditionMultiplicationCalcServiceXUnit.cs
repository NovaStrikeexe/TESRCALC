using Xunit;
using TestNetCalcWebApi.Models;
using TestNetCalcWebApi.Services;
namespace TestNetCalcWebApi.Tests
{
    public class AdditionMultiplicationCalcServiceXUnit
    {
        [Fact]
        public void ExecuteAdditionPass()
        {
            AdditionMultiplicationCalcService additionMultiplicationCalcService = new AdditionMultiplicationCalcService();
            MathExpression mathExpression = new MathExpression();
            mathExpression.NumberOne = 450;
            mathExpression.NumberTwo = 1;
            mathExpression.TypeOperation = '+';
            Assert.Equal(451, AdditionMultiplicationCalcService.Execute(mathExpression));
        }
        [Fact]
        public void ExecuteMultiplicationPass()
        {
            AdditionMultiplicationCalcService additionMultiplicationCalcService = new AdditionMultiplicationCalcService();
            MathExpression mathExpression = new MathExpression();
            mathExpression.NumberOne = 450;
            mathExpression.NumberTwo = 1;
            mathExpression.TypeOperation = '*';
            Assert.Equal(450, AdditionMultiplicationCalcService.Execute(mathExpression));
        }
        [Fact]
        public void ExecuteUnknownOperationNumberOneReturn()
        {
            AdditionMultiplicationCalcService additionMultiplicationCalcService = new AdditionMultiplicationCalcService();
            MathExpression mathExpression = new MathExpression();
            mathExpression.NumberOne = 400;
            mathExpression.NumberTwo = 5;
            mathExpression.TypeOperation = '/';
            Assert.Equal(400, AdditionMultiplicationCalcService.Execute(mathExpression));
        }
    }
}