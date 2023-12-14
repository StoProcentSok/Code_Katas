using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _9_When_Number_Is_Given
    {
        [Test]
        [TestCase(-100, false)]
        [TestCase(100, false)]
        [TestCase(1, true)]
        [TestCase(121, true)]
        [TestCase(123, false)]
        [TestCase(-121, false)]
        public void ThenTrueIfNumberIsPalindrome(int number, bool isPalindrome)
        {
            var kata = new _9_Palindrome_Number();
            var result = kata.IsPalindrome(number);

            result.Should().Be(isPalindrome);
        }
    }
}
