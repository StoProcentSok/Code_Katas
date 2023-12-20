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
    public class TestData
    {
        //public static IEnumerable<int[,]> TestMatrices()
        //{
        //    //yield return new int[3, 3] { { 100, 200, 100 }, { 200, 50, 200 }, { 100, 200, 100 } };
        //    //yield return new TestCaseData(new int[3, 3] { { 100, 200, 100 }, { 200, 50, 200 }, { 100, 200, 100 } })
        //    //    .Returns(new int[3, 3]{ { 100, 200, 100 }, { 200, 50, 200 }, { 100, 200, 100 } }) ;
        //}
    }

    [TestFixture]

    public class _661_When_Image_Array_Is_Given
    {
        [Test]
       
        public void Then_Smooth_Image_Array_Is_Returned()
        {
            int[][] inputArray =  [ [ 100, 200, 100 ], [ 200, 50, 200 ], [ 100, 200, 100 ] ];


            int [][] expectedArray = [ [ 137, 141, 137 ], [ 141, 138, 141 ], [ 137, 141, 137 ] ];

            var kata = new _661_Image_Smoother();
            var result = kata.ImageSmoother(inputArray);

            result.Should().BeEquivalentTo(expectedArray);

        }
    }
}
