public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        Dictionary<int, int> numCount = new Dictionary<int, int>();
        int[] nums = ToIntArray(s);

        foreach (int i in nums)
        {
            if (numCount.ContainsKey(i))
                numCount[i]++;
            else
                numCount[i] = 1;
        }

        string result = "";
        if (numCount.ContainsKey(1) && numCount[1] > 1)
        {
            while (numCount[1] > 1)
            {
                result += "1";
                numCount[1]--;
            }
        }

        while (numCount.ContainsKey(0) && numCount[0] > 0)
        {
            result += "0";
            numCount[0]--;
        }

        if (numCount.ContainsKey(1) && numCount[1] == 1)
        {
            result += "1";
        }

        return result;
    }

    private int[] ToIntArray(string s)
    {
        int[] nums = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            nums[i] = s[i] - '0'; // Convert char to int
        }
        return nums;
    }
}