public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] prefix = Enumerable.Repeat(1, n).ToArray();
        int[] suffix = Enumerable.Repeat(1, n).ToArray();
        int[] result = new int[n];

        for (int i = 1; i < n; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        for(int i = n - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < n; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}