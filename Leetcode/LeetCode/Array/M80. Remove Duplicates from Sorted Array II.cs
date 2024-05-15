public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int count = 0;

        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = 1;
            }
            else
                map[nums[i]]++;

            if (map[nums[i]] < 3)
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }

}