namespace DSA.Arrays.Easy
{
    public class SortedArrayMerger
    {
        private readonly IMergerStrategy _mergerStrategy;

        public SortedArrayMerger(IMergerStrategy mergerStrategy)
        {
            _mergerStrategy = mergerStrategy;
        }

        public int[] Merge(int[] numbers1, int[] numbers2, int num1Length, int num2Length)
        {
            return _mergerStrategy.Merge(numbers1, numbers2, num1Length, num2Length);
        }
    }
}
