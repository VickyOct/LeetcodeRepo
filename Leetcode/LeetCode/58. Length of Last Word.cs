public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if(s == null)
            return 0;

        string[] sParts = s.Split(' ');

        int pos = sParts.Length - 1;
        while (sParts[pos] == 0)
        {
            pos--;
        }
        return sParts[pos].Length;
    }
}