public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        Array.Sort(meetings, (a, b) => a[2].CompareTo(b[2]));

        IList<int> peopleWithSecret = new List<int>();
        peopleWithSecret.Add(0);
        peopleWithSecret.Add(firstPerson);
        int prev = 0;

        for (int i = 0; i < meetings.Length; i++)
        {
            var peopleWithSecretInMeeting = meetings[i].Take(2).Where(ppl => peopleWithSecret.Contains(ppl));
            if (peopleWithSecretInMeeting.Any())
            {
                int personLearn = meetings[i].Take(2).FirstOrDefault(ppl => !peopleWithSecret.Contains(ppl));
                if (personLearn >= 0 && personLearn < n && !peopleWithSecret.Contains(personLearn))
                    peopleWithSecret.Add(personLearn);
            }

            if (prev != 0 && meetings[i][2] == meetings[prev][2])
            {
                IList<int> peopleInSameTime = new List<int>();
                IList<int> peopleDontKnow = new List<int>();
                bool secretWillShare = false;

                foreach (int person in meetings[prev].Take(2))
                {
                    if (!peopleWithSecret.Contains(person) && !peopleDontKnow.Contains(person))
                    {
                        peopleDontKnow.Add(person);
                    }
                    if (peopleWithSecret.Contains(person))
                    {
                        secretWillShare = true;
                    }
                }

                foreach (int person in meetings[i].Take(2))
                {
                    if (!peopleWithSecret.Contains(person) && !peopleDontKnow.Contains(person))
                    {
                        peopleDontKnow.Add(person);
                    }
                    if (peopleWithSecret.Contains(person))
                    {
                        secretWillShare = true;
                    }
                }

                if (secretWillShare)
                {
                    foreach (int person in peopleDontKnow)
                    {
                        peopleWithSecret.Add(person);
                    }
                }

                prev = i;
            }
        }

        return peopleWithSecret;
    }
}
