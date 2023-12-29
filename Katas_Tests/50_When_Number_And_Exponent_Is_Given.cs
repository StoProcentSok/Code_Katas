using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _50_When_Number_And_Exponent_Is_Given
    {
        [Test]
        [TestCase(2.00000, 10, 1024.00000)]
        [TestCase(2.00000, -2, 0.25000)]
        [TestCase(1.00000, -2147483648, 1.00000)]
        public void Then_Power_Is_Calculated(double value, int exponent, double expectedSolution)
        {
            var kata = new _50_My_Pow();
            var result = kata.MyPow(value, exponent);

            result.Should().Be(expectedSolution);
        }
    }
}
