public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[] heights = new int[cols];
        int maxArea = 0;

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                heights[j] = matrix[i][j] == '1'? heights[j] + 1 : 0;
            }            
            
        }
    }
}