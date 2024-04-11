public class Solution
{
    public string RemoveKdigits(string num, int k)
    {
        int n = num.Length;
        if (k == n)
            return "0";

        Stack<char> st = new Stack<char>();
        for(int i = 0; i < n; i++)
        {
            char digit = num[i];
            while(st.Count > 0 && k > 0 && st.Peek() > digit)
            {
                st.Pop();
                k--;
            } 

            st.Push(digit);
        }

        while(k > 0)
        {
            st.Pop();
            k--;
        }

        StringBuilder sb = new StringBuilder();
        while (st.Count > 0)
            sb.Insert(0, st.Pop());

        sb.Replace("0", "").ToString();

        return sb.Length == 0? "0" : sb.ToString();
    }
}