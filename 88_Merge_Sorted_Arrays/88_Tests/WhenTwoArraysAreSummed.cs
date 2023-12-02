using NUnit.Framework;
using FluentAssertions;

namespace _88_Tests
{
    [TestFixture]
    public class WhenTwoArraysAreSummed
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 6, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [TestCase(new int[] { }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void ThenResultingArrayIsCorrect(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
           

            //var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            //var nums2 = new[] { 2, 5, 6 };
            //var expected = new[] { 1, 2, 2, 3, 5, 6 };
            #region Console writes
            Console.Write("Nums1: ");
            Console.WriteLine("[{0}]", string.Join(", ", nums1));

            Console.Write("Nums2: ");
            Console.WriteLine("[{0}]", string.Join(", ", nums2));

            Console.Write("Expected: ");
            Console.WriteLine("[{0}]", string.Join(", ", expected));
            #endregion

            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            #region console writes
            Console.Write("Result: ");
            Console.WriteLine("[{0}]", string.Join(", ", nums1));
            #endregion
            nums1.Should().BeEquivalentTo(expected);
            //Assert.AreEqual(nums1, expected);
        }
    }
}
