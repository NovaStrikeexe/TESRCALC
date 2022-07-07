using Xunit;
using TestNetCalc.Models;
namespace TestNetCalc.Tests
{
    public class BaseCalculatorTest
    {
        [Fact]
        public void AdditionTest()
        {
            BaseCalculator? baseCalculator = new BaseCalculator();
            Assert.Equal("4", baseCalculator.Addition("2", "2"));
        }
        [Fact]
        public void SubtractionTest()
        {
            BaseCalculator? baseCalculator = new BaseCalculator();
            Assert.Equal("0", baseCalculator.Subtraction("2", "2"));
        }
        [Fact]
        public void MultiplicationTest()
        {
            BaseCalculator? baseCalculator = new BaseCalculator();
            Assert.Equal("25", baseCalculator.Multiplication("5", "5"));
        }
        [Fact]
        public void DivisionTest()
        {
            BaseCalculator? baseCalculator = new BaseCalculator();
            Assert.Equal("2", baseCalculator.Division("8", "4"));

        }
        [Fact]
        public void DivisionByZeroTest()
        {
            BaseCalculator? baseCalculator = new BaseCalculator();
            Assert.Equal("Div by zero", baseCalculator.Division("8", "0"));

        }
    }
}
