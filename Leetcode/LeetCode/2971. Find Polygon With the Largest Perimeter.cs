public class Solution
{
    public long LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        int Result = -1;
        int numSum = nums[0] + nums[1];

        for (int i = 2; i < nums.Length; i++)
        {
            if(numSum >= nums[i])
            {
                Result = numSum + nums[i];
                numSum = Result;
            }
            else
            {
                break;
            }
        }
        return Result;
    }
}
