public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int count = 0;
        for(int left = 0; left < nums.Length; left++)
        {
            int right = left;
            int sum = nums[left];

            while(sum < k)
            {
                count++;
                right++;
                if (right < nums.Length)
                {
                    sum *= nums[right];
                }
                else
                {
                    break;
                }
            }
        }
        return count;
    }
}