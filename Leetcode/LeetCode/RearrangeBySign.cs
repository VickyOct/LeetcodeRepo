public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        int[] result = new int[nums.length];
        int Pos = 0;
        int Neg = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                result[Pos] = nums[i];
            }
            else
            {
                result[++Neg] = nums[i];
            }
        }
        return result;
    }
}