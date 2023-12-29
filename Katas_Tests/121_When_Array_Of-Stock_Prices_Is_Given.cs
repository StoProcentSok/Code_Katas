using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _121_When_Array_Of_Stock_Prices_Is_Given
    {
        [Test]
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 1, 9, 3, 6, 4 }, 8)]
        public void Then_Maximum_Posible_Income_Is_Returned(int[] stockPrices, int expectedIncome)
        {
            var kata = new _121_Best_Time_To_Buy_Sell_Stock();
            var result = kata.MaxProfit(stockPrices);

            result.Should().Be(expectedIncome);
        }
    }
}
