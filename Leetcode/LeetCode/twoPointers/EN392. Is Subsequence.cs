public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (t.Length == 0 && s.Length != 0)
            return false;

        int sPointer = 0;
        int tPointer = 0;

        while (sPointer < s.Length)
        {
            if (s[sPointer] == t[tPointer])
            {
                sPointer++;

                if (tPointer < t.Length - 1)
                    tPointer++;
                else
                    return false;

            }
            else if (tPointer == t.Length - 1 && s[sPointer] != s.Length)
            {
                return false;
            }
            else
            {
                tPointer++;
            }
        }
        return true;
    }
}