namespace DSA.Arrays.Easy
{
    /// <summary>
    /// In order to merge two sorted arrays, we first merge the second array into the first one and then sort the first array.
    /// Time complexity: O((m+n)log(m+n))
    /// Space complexity: O(1)
    /// </summary>
    public class MergeAndSortStrategy : IMergerStrategy
    {
        public int[] Merge(int[] numbers1, int[] numbers2, int num1Length, int num2Length)
        {

            for (int j = 0; j < num2Length; j++)
            {
                numbers1[num1Length] = numbers2[j];
                num1Length++;
            }

            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int j = i + 1; j < numbers1.Length; j++)
                {
                    if (numbers1[i] > numbers1[j])
                    {
                        int temp = numbers1[i];
                        numbers1[i] = numbers1[j];
                        numbers1[j] = temp;
                    }
                }
            }
            return numbers1;
        }
    }
}
