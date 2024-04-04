public class Solution
{
    public int MaxDepth(string s)
    {
        int count = 0;
        int Max = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                count++;
                if (count > Max)
                    Max = count;
            }
            else if (c == ')')
                count--;
        }
        return Max;
    }
}