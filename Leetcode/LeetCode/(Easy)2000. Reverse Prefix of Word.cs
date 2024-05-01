public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        if(!word.Contains(ch))
            return word;

        StringBuilder sb = new StringBuilder(word);
        int index = word.IndexOf(ch);
        int l = 0;

        while(l < index)
        {
            (sb[l], sb[index]) = (sb[index], sb[l]);
            l++;
            index--;
        }
        return sb.ToString();
    }
}
