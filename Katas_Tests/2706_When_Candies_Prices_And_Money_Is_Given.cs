using FluentAssertions;
using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Tests
{
    [TestFixture]
    public class _2706_When_Candies_Prices_And_Money_Is_Given
    {
        [Test]
        [TestCase(new int[] { 1, 2, 2 }, 3, 0)]
        [TestCase(new int[] { 3, 2, 3}, 3, 3)]
        public void ThenRemainingMoneyAfterBuyingTwoCheapestCandiesIsReturned(int[] prices, int money, int moneyReminder)
        {
            var kata = new _2706_Buy_Two_Chocolates();
            var result = kata.BuyChoco(prices, money);

            result.Should().Be(moneyReminder);
        }
    }
}
