public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int maxNum = 0;
        int maxPos = 0;
        int result = 0;
        
        foreach (int i in nums)
        {   
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;

            if(nums[i] >= maxNum)
            {
                maxNum = nums[i];
                maxPos = i;
            }
        }

        if(map[maxNum] >= k)
        {
            while(map[maxNum] >= k)
            {
                result++;

            }
        }
        else
        {
            return 0;
        }
    }
}
