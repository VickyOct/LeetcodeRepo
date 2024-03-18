﻿public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        int arrows = 1;
        int brustPower = points[0][1];

        for(int i = 1; i < points.Length; i++)
        {
            if(points[i][0] <= brustPower)
            {
                continue;
            }
            arrows++;
            brustPower = points[i][1];
        }

        return arrows;
    }
}