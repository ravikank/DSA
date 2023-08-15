namespace DSA.Arrays.Easy
{
    public class FindByRecursiveStrategy : INumberOfDigitFindingStrategy
    {
        public int GetNumberOfDigits(int number)
        {
            if (number / 10 == 0)
                return 1;
            return 1 + GetNumberOfDigits(number / 10);
        }
    }
}
