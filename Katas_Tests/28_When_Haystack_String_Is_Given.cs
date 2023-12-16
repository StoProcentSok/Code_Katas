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
    internal class _28_When_Haystack_String_Is_Given
    {
        [Test]
        [TestCase("sadbutsad", "sad", 0)]
        [TestCase("aaababbbutsad", "bbb", 5)]
        [TestCase("leetcode", "leeto", -1)]
        [TestCase("hello", "ll", 2)]
        [TestCase("a", "a", 0)]
        [TestCase("aaa", "aaaa", -1)]
        public void Then_Index_Of_Needle_String_is_Returned(string haystack, string needle, int index)
        {
            var kata = new _28_Find_Index_Of_First_Occurence();
            var result = kata.StrStr(haystack, needle);

            result.Should().Be(index);
        }
    }
}
 