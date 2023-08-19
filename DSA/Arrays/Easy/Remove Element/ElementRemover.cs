namespace DSA.Arrays.Easy
{
    public class ElementRemover
    {
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
