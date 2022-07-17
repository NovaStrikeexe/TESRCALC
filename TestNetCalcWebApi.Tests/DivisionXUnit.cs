using System;
using Xunit;
using TestNetCalcWebApi.Models.Implementation;
namespace TestNetCalcWebApi.Tests
{
    public class DivisionXUnit
    {
        [Fact]
        public void DivisionWithPositivePass()
        {
            Division division = new Division();
            Assert.Equal(12, division.CalculateResult(48, 4));
        }
        [Fact]
        public void DivisionWithNegativePass()
        {
            Division division = new Division();
            Assert.Equal(12, division.CalculateResult(-48, -4));
        }
        [Fact]
        public void DivisionWithMixedPass()
        {
            Division division = new Division();
            Assert.Equal(-12, division.CalculateResult(-48, 4));
        }
        [Fact]
        public void DivisioDivideByZeroExceptionPass()
        {
            Division division = new Division();
            Assert.True(Double.IsInfinity(division.CalculateResult(-48, 0)));
        }
    }
}