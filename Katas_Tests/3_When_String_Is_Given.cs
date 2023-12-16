using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _3_When_String_Is_Given
    {
        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("aab", 2)]
        public void Then_Longest_Substring_Length_Is_Returned(string s, int expectedLength)
        {
            var kata = new _3_Longest_Substring_Without_Repeating();
            var result = kata.LengthOfLongestSubstring(s);

            result.Should().Be(expectedLength);
        }
    }
}
