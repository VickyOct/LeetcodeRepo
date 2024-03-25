public class Solutiobn
{
    public int FindDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == nums[i + 1])
            {
                return nums[i];            
            }
        }
    }
}