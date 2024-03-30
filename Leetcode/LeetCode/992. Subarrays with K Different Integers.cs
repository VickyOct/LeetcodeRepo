public class Solution
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            List<int> numsExit = new List<int>();

            for (int pointer = i; pointer < nums.Length; pointer++)
            {
                if (!numsExit.Contains(nums[pointer]))
                {
                    numsExit.Add(nums[pointer]);
                    if (numsExit.Count > k)
                        break;

                    if (numsExit.Count == k)
                        result++;
                }
                else if (numsExit.Contains(nums[pointer]) && numsExit.Count == k)
                {
                    result++;
                }
            }
        }
        return result;
    }
}