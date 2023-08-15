namespace DSA.Arrays.Easy
{
    public class FindByInterativeStrategy : INumberOfDigitFindingStrategy
    {
        public int GetNumberOfDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
    }
}
