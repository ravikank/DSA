namespace DSA.Arrays.Easy
{
    public class SimpleStrategy : IStrategy
    {
        /// <summary>
        /// Generates squares of a sorted array and sorts it.
        /// This is very simple approach wherein we first generate squares of each element in the array and then sort it.
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Sorted squares of given numbers.</returns>
        public int[] Generate(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
