namespace DSA.Arrays.Easy
{
    public class SquareGenerator
    {
        private readonly IStrategy _strategy;

        public SquareGenerator(IStrategy strategy)
        {
            _strategy = strategy ?? new SimpleStrategy();
        }

        public int[] Generate(int[] numbers)
        {
            return _strategy.Generate(numbers);
        }
    }
}
