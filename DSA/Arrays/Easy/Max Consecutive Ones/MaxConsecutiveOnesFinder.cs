namespace DSA.Arrays.Easy
{
    public class MaxConsecutiveOnesFinder
    {
        /// <summary>
        /// Finds the maximum number of consecutive 1s in the given array.
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>maximum number of consecutive 1s in the given array.</returns>
        public static int Find(int[] nums)
        {
            int best = 0;
            int current = 0;

            foreach (var num in nums)
            {
                if (num == 1)
                {
                    current++;
                }
                else
                {
                    best = Math.Max(best, current);
                    current = 0;
                }
            }
            return Math.Max(best, current);
        }
    }
}
