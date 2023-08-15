using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class MaxConsecutiveOnesFinderTest
    {
        [Theory]
        [InlineData(new[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [InlineData(new[] { 1, 0, 1, 1, 0, 1 }, 2)]
        [InlineData(new[] { 0, 0, 0, 0, 0, 0 }, 0)]
        [InlineData(new[] { 1, 1, 1, 1, 1, 1 }, 6)]
        [InlineData(new[] { 1, 1, 1, 0, 1, 1 }, 3)]
        [InlineData(new[] { 1, 1, 1, 0, 1, 1, 1 }, 3)]
        [InlineData(new[] { 1, 1, 1, 0, 1, 1, 1, 1 }, 4)]
        [InlineData(new[] { 1, 1, 1, 0, 1, 1, 1, 1, 1 }, 5)]
        [InlineData(new[] { 1, 1, 1, 0, 1, 1, 1, 1, 1, 1 }, 6)]
        public void GivenValidArray_Find_ShouldReturnMaxConsecutiveOnes(int[] nums, int expected)
        {
            // Arrange
            // Act
            var actual = MaxConsecutiveOnesFinder.Find(nums);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
