using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _2_When_Two_Lists_Are_Given
    {
        [Test]
        [TestCase(new int[] {2,4,3}, new int[] {5,6,4}, new int[] {7,0,8})]
        public void ThenListContainingSumsIsReturned(int[] l1Values, int[] l2Values, int[] resultValues)
        {
            var kata = new _2_Add_Two_Numbers();

            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var result = kata.AddTwoNumbers(l1, l2);

            result.Should().BeEquivalentTo(new ListNode(7, new ListNode(0, new ListNode(8))));
        }
    }
}
