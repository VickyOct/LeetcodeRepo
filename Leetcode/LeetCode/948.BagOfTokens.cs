public class Solution
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        Array.Sort(tokens);
        int n = tokens.Length;
        int left = 0;
        int right = n - 1;
        int score = 0;
        int maxScore = 0;

        while (left <= right)
        {
            if (tokens[left] <= power)
            {
                score++;
                power -= tokens[left];
                left++;
            }
            else if (score > 0)
            {
                score--;
                power += tokens[right];
                right--;
            }
            else
            {
                break;
            }
            maxScore = Math.Max(maxScore, score);

        }
        return maxScore;
    }
}