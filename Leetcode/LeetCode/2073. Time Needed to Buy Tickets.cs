public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int second = 0;

        for(int i = 0; i < tickets.Length; i++)
        {
            tickets[i]--;
            second++;

            if (tickets[k] == 0)
                break;

            if (tickets[i] < 0)
            {
                second--;
            }

                if (i == tickets.Length - 1 && tickets[k] != 0)
            {
                i = -1;
            }
        }
        return second;
    }
}
