namespace DSA.Arrays.Easy
{
    /// <summary>
    /// We can start with two pointers i and j, initialized to m-1 and n-1, respectively. 
    /// We will also have another pointer k initialized to m+n-1, which will be used to keep track of the position
    /// in numbers1 where we will be placing the larger element. Then we can start iterating from the end of the 
    /// arrays i and j, and compare the elements at these positions. We will place the larger element in 
    /// numbers1 at position k, and decrement the corresponding pointer i or j accordingly. 
    /// We will continue doing this until we have iterated through all the elements in numbers2. 
    /// If there are still elements left in numbers1, we don't need to do anything because they are already in 
    /// their correct place.
    /// Time Complexity : O(m+n)
    /// Time Complexity : O(1)
    /// </summary>
    public class TwoPointersMergingStrategy : IMergerStrategy
    {
        public int[] Merge(int[] numbers1, int[] numbers2, int num1Length, int num2Length)
        {
            int i = num1Length - 1;
            int j = num2Length - 1;
            int k = num1Length + num2Length - 1;

            while (j >= 0)
            {
                if (i >= 0 && numbers1[i] > numbers2[j])
                {
                    numbers1[k--] = numbers1[i--];
                }
                else
                {
                    numbers1[k--] = numbers2[j--];
                }
            }

            return numbers1;
        }
    }
}
