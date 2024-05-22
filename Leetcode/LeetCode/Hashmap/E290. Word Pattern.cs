public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<string, char> map = new Dictionary<string, char>();
        HashSet<char> patternChar = new HashSet<char>();
        string[] words = s.Split(' ');

        if(pattern.Length != words.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string word = words[i];

            if (!map.ContainsKey(word))
            {
                if(patternChar.Contains(c))
                    return false;
            }
            else
            {
                if(map[word] != c)
                    return false;
            }

            map[word] = c;
            patternChar.Add(c);
        }
        return true;

    }
}