using FluentAssertions;
using NUnit.Framework;
using Utils;

namespace Kata_Tests
{
    [TestFixture]
    public class Utils_Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 2, 1, 10, 5, 5 }, new int[] { 1, 2, 5, 5, 10 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void QuickSortTests(int[] nums, int[] expected)
        {
             Quick_Sort.QuickSort(nums, 0, nums.Length - 1);
            nums.Should().Equal(expected);
        }
    }
}
