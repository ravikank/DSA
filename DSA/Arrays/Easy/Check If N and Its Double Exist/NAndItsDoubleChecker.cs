namespace DSA.Arrays.Easy
{
    public class NAndItsDoubleChecker
    {
        /// <summary>
        /// In order to check if N and its double exists, we need to check if any number in the array is equal to
        /// the double of any other number in the array. We can do this by using two for loops.
        /// The first for loop iterates through the array starting from the first element and the second for loop
        /// iterates through the array starting from the second element. We check if the first element is equal
        /// to the second element multiplied by 2 or if the second element is equal to the first element multiplied by 2.
        /// If the condition satisfies, we will return true. If the condition does not satisfy, we will return false.
        /// Time complexity - O(n^2)
        /// Space complexity - O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static bool CheckIfExist(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] * 2 || numbers[j] == numbers[i] * 2)
                        return true;
                }
            }
            return false;
        }
    }
}
