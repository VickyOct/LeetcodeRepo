public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 1)
            return intervals;

        List<int[]> result = new List<int[]>();
        int start = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (i <= intervals.Length - 1
                && intervals[start][1] >= intervals[i][0])
            {
                if (intervals[start][1] < intervals[i][1])
                {
                    result.Add(new int[] { intervals[start][0], intervals[i][1] });
                }
                else
                {
                    continue;
                }
            }
            else
            {
                result.Add(intervals[i]);
            }
            start = i;
        }
        return result.ToArray();
    }
}