public class Solution
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        int bricksLeft = bricks;
        int laddersLeft = ladders;
        PriorityQueue<int, int> bricksUsed = new PriorityQueue<int, int>();

        for (int i = 0; i < heights.Length - 1; i++)
        {
            int Hdif = heights[i + 1] - heights[i];
            if (Hdif > 0)
            {
                bricksLeft -= Hdif;
                bricksUsed.Enqueue(Hdif, -Hdif);
            }

            if (bricksLeft < 0)
            {
                if (laddersLeft > 0)
                {
                    bricksLeft += bricksUsed.Dequeue();
                    laddersLeft--;
                }
                else
                {
                    return i;
                }
            }

        }
        return heights.Length - 1;

    }
}
