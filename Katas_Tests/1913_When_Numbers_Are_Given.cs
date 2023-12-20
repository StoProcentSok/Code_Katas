using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _1913_When_Numbers_Are_Given
    {
        [Test]
        [TestCase(new int[] { 5, 6, 2, 7, 4 }, 34)]
        [TestCase(new int[] { 4, 2, 5, 9, 7, 4, 8 }, 64)]
        public void Then_Maximum_Product_Difference_Is_Returned(int[] nums, int expected)
        {
            var kata = new _1913_Maximum_Difference();
            var result = kata.MaxProductDifference(nums);

            result.Should().Be(expected);
        }
    }
}
