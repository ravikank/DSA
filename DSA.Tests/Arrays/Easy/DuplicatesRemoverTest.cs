using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class DuplicatesRemoverTest
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 1 }, 1)]
        public void RemoveDuplicatesTest(int[] numbers, int expected)
        {
            // Arrange
            // Act
            var actual = DuplicatesRemover.RemoveDuplicates(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
