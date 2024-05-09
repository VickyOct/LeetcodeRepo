﻿public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) return;
        int endIndex = nums1.Length - 1;

        while(m > 0 && n > 0)
        {
            if(nums2[n-1] >= nums1[m - 1])
            {
                nums1[endIndex] = nums2[n - 1];
                n--;
            }
            else{
                nums1[endIndex] = nums1[m - 1];
                m--;
            }
            endIndex--;
        }

        while(n > 0)
        {
            nums1[endIndex] = nums2[n - 1];
            n--;
            endIndex--;
        }
    }
}