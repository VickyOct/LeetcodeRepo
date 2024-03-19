public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int maxFrequency = 0;
        foreach(int i in nums)
        {
            if (frequency.ContainsKey(i))
            {
                frequency[i]++;
            }
            else
            {
                frequency[i] = 1;
            }

            if (frequency[i] > maxFrequency)
            {
                maxFrequency = frequency[i];
            }
        }

        int numWithMaxVal = frequency.Where(pair => pair.Value == maxFrequency).Count();
        int Sum = numWithMaxVal * maxFrequency;
        return Sum;
    }
}
