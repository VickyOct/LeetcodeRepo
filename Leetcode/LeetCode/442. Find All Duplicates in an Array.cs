public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;
        }

        List<int> result = map.Where(res => res.Value == 2).Select(res => res.Key).ToList();

        return result;
    }
}