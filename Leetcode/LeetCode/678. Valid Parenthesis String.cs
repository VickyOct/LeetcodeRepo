public class Solution
{
    public bool CheckValidString(string s)
    {
        int Min = 0;
        int Max = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                Min++;
                Max++;
            }
            else if (c == ')')
            {
                Min--;
                Max--;
            }
            else if (c == '*')
            {
                Min--;
                Max++;
            }

            if(Max < 0)
                return false;

            if(Min < 0)
                Min = 0;
        }

        if (Min == 0)
            return true;

        return false;
    }
}