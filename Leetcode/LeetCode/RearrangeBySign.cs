public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        int[] result = new int[nums.Length];
        int Pos = 0;
        int Neg = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                result[Pos] = nums[i];
                Pos += 2;
            }
            else
            {
                result[Neg] = nums[i];
                Neg += 2;
            }
        }
        return result;
    }
}