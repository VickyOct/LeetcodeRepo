public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i] * nums[i];
        }
        Array.Sort(result);
        return result;
    }
}