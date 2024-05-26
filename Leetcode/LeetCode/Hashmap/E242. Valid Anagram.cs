public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }

        foreach(char c in t)
        {
            if(!map.ContainsKey(c))
                return false;
            else
                map[c]--;

            if(map[c] < 0)
                return false;
        }
        return true;
    }
}