/*public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int sum = 0;
        int count = 0;

        for(int i = 0; i < people.Length; i++)
        {
            if(sum < limit)
                sum += people[i];

            int curr = sum;
            if (sum > limit)
            {
                count++;
                sum = people[i];
            }else if(sum == limit)
                count++;

            if (i == people.Length - 1 && curr != limit)
                count++;
        }

        return count;
    }
*/

public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        int left = 0;
        int right = people.Length - 1;
        int count = 0;

        while(left <= right)
        {
            if(people[left] + people[right] <= limit)
                left++;
            right--;
            count++;
        }

        return count;
    }
}
