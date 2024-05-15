public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int[][] result = new int[n - 2][];

        for (int i = 0; i < n-2; i++)
        {
            result[i] = new int[n - 2];
            for (int j = 0; j < n-2; j++)
            {
                result[i][j] = FindMaxInSubmatrix(grid, i, j);
            }
        }
        return result;
    }

    private int FindMaxInSubmatrix(int[][] grid, int row, int col)
    {
        int max = int.MinValue;
        for(int i = row; i < row + 3; i++)
        {
            for(int j = col; j < col + 3; j++)
            {
                max = Math.Max(max, grid[i][j]);
            }
        }
        return max;
    }
}