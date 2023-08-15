namespace DSA.Arrays.Easy
{
    public class FindByConvertingToStringStrategy : INumberOfDigitFindingStrategy
    {
        public int GetNumberOfDigits(int number)
        {
            return number.ToString().Length;
        }
    }
}
