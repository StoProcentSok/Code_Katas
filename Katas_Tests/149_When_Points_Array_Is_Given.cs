using FluentAssertions;
using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Kata_Tests
{
    public class _149_TestData
    {
        public static IEnumerable<TestCaseData> TestPoints()
        {
            yield return new TestCaseData(new int[3][] { new[] { 1, 1}, new[] { 2,2 }, new[] { 3, 3 } }, 3);
        }
    }

    [TestFixture]
    public class _149_When_Points_Array_Is_Given
    {
        [Test]
        [TestCaseSource(typeof(_149_TestData), nameof(_149_TestData.TestPoints))]
        public void Then_Line_Containing_Most_Points_Is_Returned(int[][] pointsArray, int maxPointsOnSilngleLine)
        {
            var kata = new _149_Max_Points_On_A_Line();
            var result = kata.MaxPoints(pointsArray);

            result.Should().Be(maxPointsOnSilngleLine);
        }
    }
}
