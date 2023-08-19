using DSA.Arrays.Easy;

namespace DSA.Tests.Arrays.Easy
{
    public class SortedArrayMergerTest
    {
        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenTwoSortedArrays_WhenMergeUsingSimpleStrategy_ThenReturnMergedSortedArray(int[] numbers1, int[] numbers2, int numbers1Length, int numbersLength, int[] expected)
        {
            // Arrange
            var merger = new SortedArrayMerger(new SimpleMergingStrategy());

            // Act
            var actual = merger.Merge(numbers1, numbers2, numbers1Length, numbersLength);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenTwoSortedArrays_WhenMergeUsingTwoPointerStrategy_ThenReturnMergedSortedArray(int[] numbers1, int[] numbers2, int numbers1Length, int numbersLength, int[] expected)
        {
            // Arrange
            var merger = new SortedArrayMerger(new TwoPointersMergingStrategy());

            // Act
            var actual = merger.Merge(numbers1, numbers2, numbers1Length, numbersLength);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void GivenTwoSortedArrays_WhenMergeUsingMergeAndSortStrategy_ThenReturnMergedSortedArray(int[] numbers1, int[] numbers2, int numbers1Length, int numbersLength, int[] expected)
        {
            // Arrange
            var merger = new SortedArrayMerger(new MergeAndSortStrategy());

            // Act
            var actual = merger.Merge(numbers1, numbers2, numbers1Length, numbersLength);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GenerateTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 2, 5, 6 }, 3, 3, new int[] { 1, 2, 2, 3, 5, 6 } };
            yield return new object[] { new int[] { 1 }, new int[] { }, 1, 0, new int[] { 1 } };
            yield return new object[] { new int[] { 0 }, new int[] { 1 }, 0, 1, new int[] { 1 } };
            yield return new object[] { new int[] { 2, 0 }, new int[] { 1 }, 1, 1, new int[] { 1, 2 } };
            yield return new object[] { new int[] { 4, 5, 6, 0, 0, 0 }, new int[] { 1, 2, 3 }, 3, 3, new int[] { 1, 2, 3, 4, 5, 6 } };
            yield return new object[] { new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 4, 5, 6 }, 3, 3, new int[] { 1, 2, 3, 4, 5, 6 } };
            yield return new object[] { new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 1, 2, 3 }, 3, 3, new int[] { 1, 1, 2, 2, 3, 3 } };
        }
    }
}
