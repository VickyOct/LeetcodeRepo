public class Solution
{
    public string MakeGood(string s)
    {
        StringBuilder SB = new StringBuilder();

        foreach (char c in s)
        {
            if(SB.Length > 0 && Math.Abs(c - SB[SB.Length - 1]) == 32)
            {
                SB.Length--;
            }
            else
            {
                SB.Append(c);
            }
        }
        return SB.ToString();
    }
}