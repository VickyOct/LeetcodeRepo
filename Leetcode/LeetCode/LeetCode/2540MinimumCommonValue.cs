public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        HashSet<int> set = new HashSet<int>(nums1);
        foreach (int i in nums2)
        {
            if (set.Contains(i))
            {
                return i;
            }
        }
        return -1;
    }
}