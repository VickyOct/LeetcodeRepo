public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Dictionary<int, int> map = new Dictionary<int, int>()
        {
            {0, 0},
            {1, 0}
        };

        foreach(int student in students)
        {
            if(map.ContainsKey(student))
                map[student]++;
        }

        foreach(int saw in sandwiches)
        {
            if (map[saw] == 0)
                break;
            map[saw]--;
        }

        return map.Values.Sum();
    }
}
