namespace DSA.Arrays.Easy
{
    public class ElementRemover
    {
        /// <summary>
        /// In order to remove element from array, we need to keep iterating over the array and compare the current element with the value.
        /// If the current element is same as value, then we need to ignore it, otherwise increment the index and assign the current element to the current index.
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int RemoveElement(int[] numbers, int value)
        {
            int i = 0;
            int j = 0;
            while (j < numbers.Length)
            {
                if (numbers[j] != value)
                {
                    numbers[i] = numbers[j];
                    i++;
                }
                j++;
            }
            return i;
        }
    }
}