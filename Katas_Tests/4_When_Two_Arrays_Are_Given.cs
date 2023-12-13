using Katas;
using NUnit.Framework;
using FluentAssertions;

namespace Kata_Tests
{
    [TestFixture]
    public class _4_When_Two_Arrays_Are_Given
    {
        [Test]
        [TestCase(new int[] {1,3}, new int[] {2}, 2.0)]
        [TestCase(new int[] {1,2}, new int[] {3, 4}, 2.5)]
        [TestCase(new int[] {1,3}, new int[] {2, 7}, 2.5)]
        public void ThenMedianIsReturned(int[] nums1, int[] nums2, double expected)
        {
            var kata = new _4_Median_Of_Two_Sorted();
            var result = kata.FindMedianSortedArrays(nums1, nums2);

            result.Should().Be(expected);
        }
    }
}
