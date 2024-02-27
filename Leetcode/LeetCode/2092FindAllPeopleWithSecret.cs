public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        Array.Sort(meetings, (a, b) => {
            int result = a[a.Length - 1].CompareTo(b[b.Length - 1]);
            if (result == 0)
            {
                int newElement = a
            }
        });
        
        IList<int> peopleWithSecret = new List<int>();
        peopleWithSecret.Add(0);
        peopleWithSecret.Add(firstPerson);

        for(int i = 0; i < meetings.Length; i++)
        {
            var peopleWithSecretInMeeting = meetings[i].Take(2).Where(ppl => peopleWithSecret.Contains(ppl));
            if (peopleWithSecretInMeeting.Any())
            {
                int peopleLearn = meetings[i].Take(2).FirstOrDefault(ppl => !peopleWithSecret.Contains(ppl));
                if(peopleLearn <= n - 1 && !peopleWithSecret.Contains(peopleLearn))
                    peopleWithSecret.Add(peopleLearn);
            }
        }
        return peopleWithSecret;
    }
}
