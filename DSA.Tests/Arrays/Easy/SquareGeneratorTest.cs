using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class SquareGeneratorTest
    {
        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GenerateUsingSimpleStrategyTest(int[] numbers, int[] expected)
        {
            // Arrange
            var squareGenerator = new SquareGenerator(new SimpleStrategy());

            // Act
            var actual = squareGenerator.Generate(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GenerateUsingAdvanceStrategyTest(int[] numbers, int[] expected)
        {
            // Arrange
            var squareGenerator = new SquareGenerator(new AdvancedStrategy());

            // Act
            var actual = squareGenerator.Generate(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GenerateTestData()
        {
            yield return new object[] { new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 } };
            yield return new object[] { new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 } };
            yield return new object[] { new int[] { -15, -9, 8, 17, 23 }, new int[] { 64, 81, 225, 289, 529 } };
        }
    }
}
