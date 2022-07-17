using System;
using Xunit;
using TestNetCalcWebApi.Models.Implementation;
namespace TestNetCalcWebApi.Tests
{
    public class SubtractionXUnit
    {
        [Fact]
        public void SubtractionTestWithNegativePass()
        {
            Subtraction subtraction = new Subtraction();
            Assert.Equal(0, subtraction.CalculateResult(-100, -100));
        }
        [Fact]
        public void SubtractionTestWithPositivePass()
        {
            Subtraction subtraction = new Subtraction();
            Assert.Equal(0, subtraction.CalculateResult(100, 100));
        }
    }
}