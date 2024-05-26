public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();

        if (nums.Length == 0)
            return result;

        int start = 0;

        for (int i = 1; i <= nums.Length; i++)
        {
            if (i == nums.Length || nums[i] != nums[i - 1] + 1)
            {
                if (start == i - 1)
                {
                    result.Add(nums[start].ToString());
                }
                else
                {
                    result.Add($"{nums[start]}->{nums[i - 1]}");
                }
                start = i;
            }
        }

        return result;
    }
}