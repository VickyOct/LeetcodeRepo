public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if(s.Length != t.Length)
            return false;

        Dictionary<char, char> map = new Dictionary<char, char>();
        HashSet<char> tSet = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char sChar = s[i];
            char tChar = t[i];
            if (!map.ContainsKey(sChar))
            {
                if(tSet.Contains(tChar))
                    return false;
            }
            else
            {
                if(tChar != map[sChar])
                    return false;
            }

            map[sChar] = tChar;
            tSet.Add(tChar);
        }
        return true;
    }
}
