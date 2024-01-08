using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    public class _1637_TestData
    {
        public static IEnumerable<TestCaseData> TestPoints()
        {
            yield return new TestCaseData(new int[4][] { [8, 7], [9, 9], [7, 4], [9, 7] }, 1);
            yield return new TestCaseData(new int[6][] { [3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8,8] }, 3);
        }
    }


    [TestFixture]
    public class _1637_When_Points_Array_Is_Given
    {
        [Test]
        [TestCaseSource(typeof(_1637_TestData), nameof(_1637_TestData.TestPoints))]
        public void Then_Widest_Verical_Area_Between_Points_Is_Returned(int[][] points, int widestArea)
        {
            var kata = new _1637_Widest_Area_Without_Point();
            var result = kata.MaxWidthOfVerticalArea(points);

            result.Should().Be(widestArea);
        }
    }
}
