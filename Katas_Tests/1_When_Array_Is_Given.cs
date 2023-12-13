using NUnit.Framework;
using Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Kata_Tests
{
    [TestFixture]
    internal class _1_When_Array_Is_Given
    {
        [Test]
        [TestCase(new int[] { 2, 7, 11,15}, 9, new int[] {0,1})]
        [TestCase(new int[] { 3, 2, 4}, 6, new int[] {1,2})]
        [TestCase(new int[] { 3, 3}, 6, new int[] {0,1})]
        public void ThenProperPairOfIndexesIsGiven(int[] nums, int target, int[] expected)
        {
            var kata = new _1_Two_Sum();
            var result = kata.TwoSum(nums, target);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
