public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;
        int pos = 0;
        int positiveInt = 1;

        while (nums[pos] <= 0)
        {
            pos++;
            if (pos >= n)
                return 1;
        }


        for (int i = pos; i < n; i++)
        {
            if (nums[i] == positiveInt)
            {
                positiveInt++;
            }
            else if (i > pos && nums[i] == nums[i - 1])
            {
                continue;
            }
            else
            {
                return positiveInt;
            }
        }
        return positiveInt;
    }
}