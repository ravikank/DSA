namespace DSA.Arrays.Easy
{
    public class EvenNumberOfDigitFinder
    {
        private readonly INumberOfDigitFindingStrategy _digitFindingStrategy;

        public EvenNumberOfDigitFinder(INumberOfDigitFindingStrategy digitFindingStrategy)
        {
            _digitFindingStrategy = digitFindingStrategy;
        }

        public int Find(int[] numbers)
        {
            int count = 0;
            
            foreach (var number in numbers)
            {
                if (_digitFindingStrategy.GetNumberOfDigits(number) % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
