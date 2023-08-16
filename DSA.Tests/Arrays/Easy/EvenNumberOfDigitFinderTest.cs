using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class EvenNumberOfDigitFinderTest
    {
        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenValidArray_Find_ShouldReturnEvenNumberOfDigitsUsingIterativeStrategyTest(int[] numbers, int expected)
        {
            // Arrange
            INumberOfDigitFindingStrategy strategy = new FindByInterativeStrategy();
            var finder = new EvenNumberOfDigitFinder(strategy);

            // Act
            var actual = finder.Find(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenValidArray_Find_ShouldReturnEvenNumberOfDigitsUsingRecursiveStrategyTest(int[] numbers, int expected)
        {
            // Arrange
            INumberOfDigitFindingStrategy strategy = new FindByRecursiveStrategy();
            var finder = new EvenNumberOfDigitFinder(strategy);

            // Act
            var actual = finder.Find(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenValidArray_Find_ShouldReturnEvenNumberOfDigitsUsingConvertToStringStrategyTest(int[] numbers, int expected)
        {
            // Arrange
            INumberOfDigitFindingStrategy strategy = new FindByConvertingToStringStrategy();
            var finder = new EvenNumberOfDigitFinder(strategy);

            // Act
            var actual = finder.Find(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenValidArray_Find_ShouldReturnEvenNumberOfDigitsUsingLogarithmStrategyTest(int[] numbers, int expected)
        {
            // Arrange
            INumberOfDigitFindingStrategy strategy = new FindByLogarithmStrategy();
            var finder = new EvenNumberOfDigitFinder(strategy);

            // Act
            var actual = finder.Find(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GenerateTestData()
        {
            yield return new object[] { new int[] { 12, 345, 2, 6, 7896 }, 2 };
            yield return new object[] { new int[] { 555, 901, 482, 1771 }, 1 };
            yield return new object[] { new int[] { 22, 4444, 666666, 1, 333, 55555 }, 3 };
        }
    }
}
