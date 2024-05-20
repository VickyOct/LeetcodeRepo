public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sPointer = 0;
        int tPointer = 0;

        while (sPointer < s.Length && tPointer < t.Length)
        {
            if (s[sPointer] == t[tPointer])
            {
                sPointer++;
            }
            tPointer++;

        }
        return sPointer == s.Length;
    }
}