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
            int left = 0;
            int right = word.Length - 1;
            while (charArray[left] == charArray[right])
            {
                if (left >= right)
                    return word;
                left++;
                right--;
            };
        }
        return "";
    }
}
