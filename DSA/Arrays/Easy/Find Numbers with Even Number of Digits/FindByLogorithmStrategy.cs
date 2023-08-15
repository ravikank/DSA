namespace DSA.Arrays.Easy
{
    public class FindByLogarithmStrategy : INumberOfDigitFindingStrategy
    {
        public int GetNumberOfDigits(int number)
        {
            return (int)Math.Log10(number) + 1;
        }
    }
}
