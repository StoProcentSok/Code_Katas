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
    public class _661_TestData
    {
        public static IEnumerable<TestCaseData> TestMatrices()
        {
            yield return new TestCaseData(new int[3][] { new[] { 100, 200, 100 }, new[] { 200, 50, 200 }, new[] { 100, 200, 100 } },
                                          new int[3][] { new[] { 137, 141, 137 }, new[] { 141, 138, 141 }, new[] { 137, 141, 137 } });
        }
    }

    [TestFixture]

    public class _661_When_Image_Array_Is_Given
    {
        [Test]
        [TestCaseSource(typeof(_661_TestData), nameof(_661_TestData.TestMatrices))]
        public void Then_Smooth_Image_Array_Is_Returned(int[][] inputArray, int[][] expectedArray)
        {
            var kata = new _661_Image_Smoother();
            var result = kata.ImageSmoother(inputArray);

            result.Should().BeEquivalentTo(expectedArray);
        }
    }
}
