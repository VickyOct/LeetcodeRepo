public class Solution
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int maxLength = 0;
        int repeatPointer = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
                if (map[nums[i]] > k)
                {
                    maxLength = Math.Max(i - repeatPointer, maxLength);
                    repeatPointer = i;
                }
            }
            else
                map[nums[i]] = 1;
        }

        if(maxLength != 0)
        {
            return maxLength;
        }
        else
        {
            return nums.Length;
        }
    }
}