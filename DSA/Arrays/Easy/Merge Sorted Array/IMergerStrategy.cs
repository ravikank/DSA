namespace DSA.Arrays.Easy
{
    public interface IMergerStrategy
    {
        public int[] Merge(int[] numbers1, int[] numbers2, int num1Length, int num2Length);
    }
}