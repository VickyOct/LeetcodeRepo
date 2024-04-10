public class Solution
{
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        Array.Sort(deck);
        Queue<int> indexQueue = new Queue<int>(Enumerable.Range(0, deck.Length));
        int[] result = new int[deck.Length];

        foreach (int card in deck)
        {
            result[indexQueue.Dequeue()] = card;
            if(indexQueue.Count > 0)
                indexQueue.Enqueue(indexQueue.Dequeue());
        }
        return result;
    }
}