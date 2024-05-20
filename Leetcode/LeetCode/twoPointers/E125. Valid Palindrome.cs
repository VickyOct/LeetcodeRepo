public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        s = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray());
        if (s.Length < 1)
            return true;

        int left = 0;
        int right = s.Length -1;

        for (int i = 0; i < s.Length; i++)
        {
            if(s[left] != s[right])
                return false;

            left++;
            right--;
        }
        return true;
    }
}