using Xunit;
using TestNetCalcWebApi.Models.Implementation;
namespace TestNetCalcWebApi.Tests
{
    public class AdditionXUnit
    {
        [Fact]
        public void AdditionTestWithPositivePass()
        {
            Addition addition = new Addition();
            Assert.Equal(2021, addition.CalculateResult(2000, 21));
        }
        [Fact]
        public void AdditionTestWithNegativePass()
        {
            Addition addition = new Addition();
            Assert.Equal(-2021, addition.CalculateResult(-2000, -21));
        }
    }
}