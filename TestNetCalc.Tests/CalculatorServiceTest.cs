using Newtonsoft.Json.Linq;
using Xunit;
using Moq;
using System.Text.Json;
using TestNetCalc.Models;
using TestNetCalc.Service;

namespace TestNetCalc.Tests
{
    public class CalculatorServiceTest
    {
        [Fact]
        public void ExpresionToJsonTest()
        {
            Assert.Equal("{\"NumberOne\":\"-5\",\"NumberTwo\":\"5\",\"TypeOperation\":\"*\"}", CalculatorService.ExpresionToJson("-5*5"));
        }
        [Fact]
        public void ConvertToExpressionTypeTest()
        {
            //Act
            MathExpression expectedMathExpression = new MathExpression();
            expectedMathExpression.NumberOne = "2";
            expectedMathExpression.NumberTwo = "2";
            expectedMathExpression.TypeOperation = '+';
            MathExpression actualMathExpression = new MathExpression();
            actualMathExpression = CalculatorService.ConvertToExpressionType("{\"NumberOne\":\"2\",\"NumberTwo\":\"2\",\"TypeOperation\":\"+\"}");
            //Assert
            Assert.Equal(expectedMathExpression.NumberOne, actualMathExpression.NumberOne);
            Assert.Equal(expectedMathExpression.NumberTwo, actualMathExpression.NumberTwo);
            Assert.Equal(expectedMathExpression.TypeOperation, actualMathExpression.TypeOperation);

        }
        [Fact]
        public void ReturnResultOfExpessionAdditionTest()
        {
            Assert.Equal("10", CalculatorService.ReturnResultOfExpession("5+5"));
        }
        [Fact]
        public void ReturnResultOfExpessionSubtractionTest()
        {
            Assert.Equal("0", CalculatorService.ReturnResultOfExpession("5-5"));
        }
        [Fact]
        public void ReturnResultOfExpessionMultiplicationTest()
        {
            Assert.Equal("25", CalculatorService.ReturnResultOfExpession("5*5"));
        }
        [Fact]
        public void ReturnResultOfExpessionDivisionTest()
        {
            Assert.Equal("1", CalculatorService.ReturnResultOfExpession("2/2"));
        }
        [Fact]
        public void ReturnResultOfExpessionDivisionByZeroTest()
        {
            Assert.Equal("Div by zero", CalculatorService.ReturnResultOfExpession("2/0"));//Unknown expression
        }
        [Fact]
        public void ReturnResultOfExpessionDivisionUnknownExpressionTest()
        {
            Assert.Equal("Unknown expression", CalculatorService.ReturnResultOfExpession("5-*6"));
        }

    }
}