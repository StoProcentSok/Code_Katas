using FluentAssertions;
using Katas;
using NUnit.Framework;

namespace Kata_Tests
{
    [TestFixture]
    public class _11_When_Array_Of_Container_Constrains_Is_Given
    {
        [Test]
        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new int[] { 1, 1 }, 1)]
        public void Then_Container_Holding_Most_Water_Is_Returned(int[] height, int maxVolume)
        {
            var kata = new _11_Container_With_Most_Water();
            var result = kata.MaxArea(height);

            result.Should().Be(maxVolume);
        }
    }
}
