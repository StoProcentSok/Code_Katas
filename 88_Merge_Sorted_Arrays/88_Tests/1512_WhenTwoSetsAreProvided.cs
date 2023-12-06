using FluentAssertions;
using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Tests
{
    [TestFixture]
    internal class _1512_WhenTwoSetsAreProvided
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 6)]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        public void ThenPairsAreReturned(int[] numbers, int expectedPairs)
        {
            var kata = new _1512_Number_Of_Good_Pairs();
            var result = kata.NumIdenticalPairs(numbers);

            result.Should().Be(expectedPairs);
        }
    }
}
