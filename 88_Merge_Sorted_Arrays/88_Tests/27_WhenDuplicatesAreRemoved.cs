using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Katas;
using NUnit;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    internal class _27_WhenGivenOccurencesAreRemoved
    {
        [Test]
        [TestCase(new int[] {3,2,2,3}, 3, 2, new int[] {2,2} )]
        [TestCase(new int[] {0,1,2,2,3,0,4,2}, 2, 5, new int[] {0,1,3,0,4} )]
        public void ThenProperCountAndArrayIsReturned(int[] nums, int valueToRemove, int expectedLeftValues, int[] expectedNums)
        {
            var kata = new _27_Remove_Element();
            var result = kata.RemoveElement(nums, valueToRemove);

            result.Should().Be(expectedLeftValues);
            nums.Should().StartWith(expectedNums);
        }
    }
}
