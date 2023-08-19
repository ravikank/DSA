namespace DSA.Arrays.Easy
{
    /// <summary>
    /// In order to merge 2 sorted arrays, for each element in the second array, we find its correct position
    /// in the first array and insert it there.
    /// Time complexity: O(m*n)
    /// Space complexity: O(1)
    /// </summary>
    public class SimpleMergingStrategy : IMergerStrategy
    {
        public int[] Merge(int[] numbers1, int[] numbers2, int num1Length, int num2Length)
        {
            for (int i = 0; i < numbers2.Length; i++)
            {
                for (int j = 0; j < numbers1.Length; j++)
                {
                    if (numbers2[i] <= numbers1[j])
                    {
                        for (int k = num1Length; k > j; k--)
                        {
                            numbers1[k] = numbers1[k - 1];
                        }
                        numbers1[j] = numbers2[i];
                        num1Length++;
                        break;
                    }
                    if (j == numbers1.Length - 1)
                    {
                        if (j == 0)
                        {
                            numbers1[j] = numbers2[i];
                        }
                        else
                        {
                            numbers1[num1Length] = numbers2[i];
                            num1Length++;
                        }
                    }
                }
            }
            return numbers1;
        }
    }
}
