namespace DSA.Arrays.Easy
{
    public class NAndItsDoubleChecker
    {
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
