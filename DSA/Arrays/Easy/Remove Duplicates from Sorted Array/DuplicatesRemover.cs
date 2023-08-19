namespace DSA.Arrays.Easy
{
    public class DuplicatesRemover
    {
        /// <summary>
        /// In order to remove duplicates from sorted array, we need to keep iterating over the array and compare the current element with the next element.
        /// Ignore if the current is same as next element, otherwise increment the index and assign the next element to the current index.
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] numbers)
        {
            int i = 0;
            int j = 0;
            while(j < numbers.Length)
            {
                if (numbers[i] != numbers[j])
                {
                    i++;
                    numbers[i] = numbers[j];
                }
                j++;
            }
            return i + 1;
        }
    }
}