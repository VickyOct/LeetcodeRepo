public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        foreach(int i in nums1)
        {
            if (!result.Contains(i) && nums2.Contains(i))
            {
                result.Add(i);
            }
        }
        return result.ToArray();
    }
}