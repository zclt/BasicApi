using Basic.Common;
using FluentAssertions;
using Xunit;

namespace BasicApi.Test
{
    public class IntExtensionsTest
    {
        [Fact]
        public void ToIntTest()
        {
            //arrange
            var stringValues = new[] { "1", "2", "3", " 4", "-5", "6 ", "  7 ", "a", "", null, "null" };
            var expectedValues = new[] { 1, 2, 3, 4, -5, 6, 7, default, default, default, default };
            
            //act
            var intValues = stringValues.ToInt();

            //assert
            expectedValues.Should().BeEquivalentTo(intValues);
        }
    }
}