using NUnit.Framework;
using FluentAssertions;
using Katas;

namespace Kata_Tests
{
    [TestFixture]
    public class _88_WhenTwoArraysAreSummed
    {
        [Test]
        //[TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 6, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        //[TestCase(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        //[TestCase(new int[] { 0 }, 1, new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 2, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 2 })]
        public void ThenResultingArrayIsCorrect(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            #region Console writes
            Console.Write("Nums1: ");
            Console.WriteLine("[{0}]", string.Join(", ", nums1));

            Console.Write("Nums2: ");
            Console.WriteLine("[{0}]", string.Join(", ", nums2));

            Console.Write("Expected: ");
            Console.WriteLine("[{0}]", string.Join(", ", expected));
            #endregion

            var solution = new _88_Merge_Sorted_Arrays();
            solution.Merge(nums1, m, nums2, n);

            #region console writes
            Console.Write("Result: ");
            Console.WriteLine("[{0}]", string.Join(", ", nums1));
            #endregion
            nums1.Should().BeEquivalentTo(expected);
        }
    }
}
