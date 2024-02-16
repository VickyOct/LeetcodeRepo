using System;

public class Solution
{
    public string FirstPalindrome(string[] words)
    {
        if (words == null)
            return "";

        foreach (string word in words)
        {
            char[] charArray = word.ToCharArray();
            int center = (word.Length - 1) / 2;
            int left = center - 1;
            int right = center + 1;
            while (left >= 0 && right < charArray.Length && charArray[left] == charArray[right])
            {
                left--;
                right++;
                if(left < 0)
                    return word;
            };
        }
        return "";
    }
}
