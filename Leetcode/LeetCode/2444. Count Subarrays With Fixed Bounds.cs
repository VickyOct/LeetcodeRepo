public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        int left = 0;
        int right = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        int result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == minK)
            {
                minK = nums[i];
                left = i;
            }
            if (nums[i] == maxK)
            {
                maxK = nums[i];
                right = i;
            }

            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = 0;
            else
                map[nums[i]]++;
        }



    }
}