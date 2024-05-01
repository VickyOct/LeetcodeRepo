public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> brackets = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(')
                brackets.Push(')');
            else if (c == '{')
                brackets.Push('}');
            else if (c == '[')
                brackets.Push(']');
            else if (brackets.Count == 0 || brackets.Pop() != c)
                return false;
        }
        return brackets.Count == 0;
    }
}