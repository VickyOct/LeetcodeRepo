public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = 0;

        for(int i = 0; i < height.Length; i++)
        {
            if(height[i] >= left )
                left = height[i];

            if(left < right)
        }
    }
}