using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class MaxConsecutiveOnesFinderTest
    {
        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenValidArray_Find_ShouldReturnMaxConsecutiveOnes(int[] nums, int expected)
        {
            // Arrange
            // Act
            var actual = MaxConsecutiveOnesFinder.Find(nums);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GenerateTestData()
        {
            yield return new object[] { new[] { 1, 1, 0, 1, 1, 1 }, 3 };
            yield return new object[] { new[] { 1, 0, 1, 1, 0, 1 }, 2 };
            yield return new object[] { new[] { 0, 0, 0, 0, 0, 0 }, 0 };
            yield return new object[] { new[] { 1, 1, 1, 1, 1, 1 }, 6 };
            yield return new object[] { new[] { 1, 1, 1, 0, 1, 1 }, 3 };
            yield return new object[] { new[] { 1, 1, 1, 0, 1, 1, 1 }, 3 };
            yield return new object[] { new[] { 1, 1, 1, 0, 1, 1, 1, 1 }, 4 };
            yield return new object[] { new[] { 1, 1, 1, 0, 1, 1, 1, 1, 1 }, 5 };
            yield return new object[] { new[] { 1, 1, 1, 0, 1, 1, 1, 1, 1, 1 }, 6 };
        }
    }
}
