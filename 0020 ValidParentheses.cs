namespace Task20
{
    public class Solution
    {
        bool IsPair(char a, char b)
        {
            return a == '(' && b == ')'
                || a == '[' && b == ']'
                || a == '{' && b == '}';
        }
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0 && IsPair(stack.Peek(), c))
                    stack.Pop();
                else
                    stack.Push(c);
            }

            if (stack.Count == 0)
                return true;
            return false;
        }
    }
}