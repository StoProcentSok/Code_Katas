using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _20_When_Parentheses_String_Is_Given
    {
        [Test]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("]", false)]
        public void Then_Validity_Of_OpenClose_Is_Checked(string s, bool expected)
        {
            var kata = new _20_Valid_Parentheses();
            var result = kata.IsValid(s);
            result.Should().Be(expected);

        }
    }
}
