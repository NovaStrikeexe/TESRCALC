using System;
using Xunit;
using TestNetCalcWebApi.Models.Implementation;
namespace TestNetCalcWebApi.Tests
{
    public class MultiplicationXUnit
    {
        [Fact]
        public void MultiplicationPositivePass()
        {
            Multiplication multiplication = new Multiplication();
            Assert.Equal(60, multiplication.CalculateResult(15, 4));
        }
        [Fact]
        public void MultiplicationNegativePass()
        {
            Multiplication multiplication = new Multiplication();
            Assert.Equal(60, multiplication.CalculateResult(-15, -4));
        }
        [Fact]
        public void MultiplicationMixedPass()
        {
            Multiplication multiplication = new Multiplication();
            Assert.Equal(-6, multiplication.CalculateResult(1.5, -4));
        }
    }
}