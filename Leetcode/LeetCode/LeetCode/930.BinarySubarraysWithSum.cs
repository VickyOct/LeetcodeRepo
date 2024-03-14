public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        int count = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = 1;
        int sum = 0;

        foreach (int num in nums)
        {
            sum += num;
            int rem = sum - goal;
            if (map.ContainsKey(rem))
            {
                count += map[rem];
            }
            if (!map.ContainsKey(sum))
            {
                map[sum] = 0;
            }
            map[sum]++;
        }
        return count;
    }
}