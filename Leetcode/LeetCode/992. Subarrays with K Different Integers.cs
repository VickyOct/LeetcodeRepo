public class Solution
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        return AtMostKDistinct(nums, k) - AtMostKDistinct(nums, k - 1);
    }
    private int AtMostKDistinct(int[] nums, int k)
    {
        int result = 0;
        Dictionary<int, int> numsExit = new Dictionary<int, int>();
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (!numsExit.ContainsKey(nums[right]))
            {
                numsExit[nums[right]] = 0;
            }
            numsExit[nums[right]]++;

            while (numsExit.Count > k)
            {
                numsExit[nums[left]]--;
                if (numsExit[nums[left]] == 0)
                {
                    numsExit.Remove(nums[left]);
                }
                left++;
            }
            result += right - left + 1;
        }
        return result;
    }
}