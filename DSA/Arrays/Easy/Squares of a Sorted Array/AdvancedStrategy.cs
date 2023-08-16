namespace DSA.Arrays.Easy
{
    public class AdvancedStrategy : IStrategy
    {
        public int[] Generate(int[] numbers)
        {
            var squares = new int[numbers.Length];
            var left = 0;
            var right = numbers.Length - 1;
            var index = numbers.Length - 1;

            while (left <= right)
            {
                var leftSquare = numbers[left] * numbers[left];
                var rightSquare = numbers[right] * numbers[right];

                if (leftSquare > rightSquare)
                {
                    squares[index] = leftSquare;
                    left++;
                }
                else
                {
                    squares[index] = rightSquare;
                    right--;
                }
                index--;
            }
            return squares;
        }
    }
}
