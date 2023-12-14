using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _7_When_Integer_Is_Given
    {
        [Test]
        [TestCase(100, 1)]
        [TestCase(123, 321)]
        [TestCase(-231, -132)]
        [TestCase(1534236469, 0)]
        public void Then_Reverse_Integer_Is_Returned(int value, int expected)
        {
            var kata = new _7_Reverse_Integer();
            var result = kata.Reverse(value);

            result.Should().Be(expected);
        }
    }
}
