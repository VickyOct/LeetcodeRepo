public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new List<int[]>();
        int start = newInterval[0];
        int end = newInterval[1];
        int size = intervals.Length;
        int i = 0;

        while(i < size && intervals[i][1] < start)
        {
            result.Add(intervals[i]);
            i++;
        }

        while(i < size && intervals[i][0] <= end)
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);

        while(i < size)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();

        /*int pointer = 0;
        int start = newInterval[0];
        int end = newInterval[1];
        int size = intervals.Length;
        List<int[]> result = new List<int[]>;
        int[] temp = new int[2];

        for (int i = 0; i < size - 1; i++)
        {
            if (intervals[i][pointer] < start)
            {
                if (pointer == 0)
                    temp[0] = intervals[i][0];

                pointer++;
                if(pointer == 1)
                {
                    result.Add(intervals[i]);
                    pointer = 0;
                    continue;
                }
            }



            if(intervals[i][pointer] > end)
            {
                if(pointer == 0)
               

                if(pointer == 1)
                {

                }
            }

            i++;
        }

            int size = intervals.Length;
            int start = newInterval[0];
            int end = newInterval[1];
            List<int[]> result = new List<int[]>;
            int[] temp = new int[2];

            for (int i = 0; i < size - 1; i++)
            {
                if(intervals[i][0] < start && intervals[i][1] <= start)
                {
                    result.Add(intervals[i]);
                    i++;
                    continue;
                }else if(intervals[i][1] > start && intervals[i][1] <= end)
                {
                    if(temp[0] == null)
                        temp[0] = intervals[i][0];

                    if (intervals[i+1][0] > end)
                    {
                        temp[1] = end;
                        result.Add(temp);
                    }
                    else if(intervals[i][1] < end)
                    {
                        i++;
                    }
                }
            }*/


    }
}
