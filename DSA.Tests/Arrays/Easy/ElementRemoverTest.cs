using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class ElementRemoverTest
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 })]
        [InlineData(new int[] { 1 }, 1, new int[] { })]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 1, new int[] { })]
        [InlineData(new int[] { 1, 2, 1, 1, 1 }, 2, new int[] { 1, 1, 1, 1 })]
        public void RemoveElementTest(int[] numbers, int value, int[] expected)
        {
            // Arrange
            var elementRemover = new ElementRemover();

            // Act
            var actual = elementRemover.RemoveElement(numbers, value);

            // Assert
            Assert.Equal(expected.Length, actual);
            for (int i = 0; i < actual; i++)
            {
                Assert.Equal(expected[i], numbers[i]);
            }
        }
    }
}
