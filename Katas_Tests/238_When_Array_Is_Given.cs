using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _238_When_Array_Is_Given
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [TestCase(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        public void Then_Array_Of_Product_WIthout_Selfs_Is_Returned(int[] nums, int[] expected)
        {
            var kata = new _238_Product_Of_Array_Except_Self();
            var result = kata.ProductExceptSelf(nums);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
