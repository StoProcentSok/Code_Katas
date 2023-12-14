using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    public class _135_When_Array_Of_Ratings_Is_Given
    {
        [Test]
        [TestCase(new int[] {1, 0, 2}, 5)]
        [TestCase(new int[] {1, 2, 2}, 4)]
        [TestCase(new int[] {29, 51, 87, 87, 72, 12}, 12)]
        [TestCase(new int[] {1,2,3,2,1}, 9)]
        public void Then_Candies_Count_Is_Returned(int[] ratings, int candies)
        {
            var kata = new _135_Candy();
            var result = kata.Candy(ratings);

            result.Should().Be(candies);

        }
    }
}
