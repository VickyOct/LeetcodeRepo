public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int temp = i + 1;
            int right = nums.Length - 1;

            while (right > temp)
            {
                int sum = nums[i] + nums[right] + nums[temp];
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[right], nums[temp] });

                    while (temp < right && nums[right] == nums[right - 1])
                        right--;

                    while (temp < right && nums[temp] == nums[temp + 1])
                        temp++;

                    temp++;
                    right--;

                }
                else if (sum < 0)
                {
                    temp++;
                }
                else
                    right--;
            }
        }
        return result;
    }
}