public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int i in arr)
            if (map.ContainsKey(i))
                map[i]++;
            else
                map[i] = 1;

        var sortedMaps = map.OrderBy(pair => pair.Value).ToList();

        foreach (var sortedMap in sortedMaps)
        {
            if (k > 0)
            {
                if (k >= sortedMap.Value)
                {
                    k -= sortedMap.Value;
                    map.Remove(sortedMap.Key);
                }
                else
                {
                    break;
                }
            }
            else
                break;
        }
        return map.Count;
    }
}