public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int curSum = 0;
        int maxSum = nums[0];
        foreach (int i in nums)
        {
            curSum = Math.Max(i, i + curSum);
            maxSum = Math.Max(maxSum, curSum);
        }
        return maxSum;
    }
}