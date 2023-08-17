using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class ZeroDuplicatorTest
    {
        [Theory]
        [InlineData(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 0, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 0, 0, 2, 3, 0, 0 })]
        [InlineData(new int[] { 1, 0, 2, 3, 0, 4, 5, 0, 6 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4, 5 })]
        public void GiveArrayWithZeros_ShouldDuplicateZeros(int[] numbers, int[] expected)
        {
            // Arrange
            var duplicator = new ZeroDuplicator();

            // Act
            var actual = duplicator.Duplicate(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
