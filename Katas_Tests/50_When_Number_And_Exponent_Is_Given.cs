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
    public class _50_When_Number_And_Exponent_Is_Given
    {
        [Test]
        [TestCase(2.00000, 10, 1024.00000)]
        [TestCase(2.10000, 3, 9.26100)]
        [TestCase(2.00000, -2, 0.25000)]
        [TestCase(0.44893, -5, 54.83508)]
        public void Then_Power_Is_Calsulated(double value, int exponent, double expectedSolution)
        {
            var kata = new _50_My_Pow();
            var result = kata.MyPow(value, exponent);

            result.Should().Be(expectedSolution);
        }
    }
}
