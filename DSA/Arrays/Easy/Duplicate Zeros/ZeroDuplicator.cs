namespace DSA.Arrays.Easy
{
    public class ZeroDuplicator
    {
        public int[] Duplicate(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    for (int j = numbers.Length - 1; j > i; j--)
                    {
                        numbers[j] = numbers[j - 1];
                    }
                    i++;
                }
            }
            return numbers;
        }
    }
}
