using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _219_When_Nums_Arr_Is_Given
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 1 }, 3, true)]
        [TestCase(new int[] { 1, 0, 1, 1 }, 1, true)]
        [TestCase(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
        public void Then_True_If_Duplicates_Fullfill_Rule(int[] nums, int k, bool expected)
        {
            var kata = new _219_Contains_Duplicate_II();
            var result = kata.ContainsNearbyDuplicate(nums, k);

            result.Should().Be(expected);
        }
    }
}
