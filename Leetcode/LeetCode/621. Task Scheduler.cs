public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        int[] freq = new int[26];

        foreach (char c in tasks)
        {
            freq[c - 'A']++;
        }

        Array.Sort(freq);

        int maxfreq = freq[25] - 1;
        int idleSlots = maxfreq * n;

        for (int i = 24; i>= 0 && freq[i] > 0; i--)
        {
            idleSlots -= Math.Min(freq[i], maxfreq);
        }

        return Math.Max(idleSlots, 0) + tasks.Length;
    }
}