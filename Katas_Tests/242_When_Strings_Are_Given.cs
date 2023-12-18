using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _242_When_Strings_Are_Given
    {
        [Test]
        [TestCase("anagram", "nagaram", true)]
        [TestCase("rat", "car", false)]
        public void Then_Anagram_Status_Is_Returned(string s, string t, bool isAnagram)
        {
            var kata = new _242_Valid_Anagram();
            var result = kata.IsAnagram(s, t);

            result.Should().Be(isAnagram);
        }
    }
}
