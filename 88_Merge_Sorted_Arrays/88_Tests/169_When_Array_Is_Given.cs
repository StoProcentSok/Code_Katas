using Katas;
using NUnit.Framework;
using System;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Tests
{
    [TestFixture]
    public class _169_When_Array_Is_Given
    {
        [Test]
        [TestCase(new int[] {3, 2, 3}, 3)]
        [TestCase(new int[] {2, 2, 1, 1, 2, 2}, 2)]
        public void Then_Majority_Element_Is_Returned(int[] nums, int expected)
        {
            var Kata = new _169_Majority_Elements();
            var result = Kata.MajorityElement(nums);

            result.Should().Be(expected);
        }
    }
}
