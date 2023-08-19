using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class NAndItsDoubleCheckerTest
    {
        [Theory]
        [InlineData(new int[] { 10, 2, 5, 3 }, true)]
        [InlineData(new int[] { 7, 1, 14, 11 }, true)]
        [InlineData(new int[] { 3, 1, 7, 11 }, false)]
        public void CheckIfExistTest(int[] numbers, bool expected)
        {
            bool actual = NAndItsDoubleChecker.CheckIfExist(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
